import React, { useEffect, useState } from 'react';
import { useGetVehiclesQuery } from '../../Api/vehicleApi';
import './Styles/VehicleList.css';
import Circle from './Circle';
import { Link } from 'react-router-dom';
import Banner from './Banner';
import { useSelector } from 'react-redux';
import { RootState } from '../../Storage/store';
import { SD_FilterTypes } from '../../interfaces/enums/SD_FilterTypes';
import { vehicleModel } from '../../interfaces/vehicleModel';

const ITEMS_PER_PAGE = 8;
// Filtreler için kullanılan seçeneklerin dışında, pagination için tanımlı özel bir değer oluşturuyoruz.
const PAGINATION = "Pagination";

function VehicleList() {
  const { data, isLoading } = useGetVehiclesQuery(null);
  const [filterResponse, setFilterResponse] = useState<vehicleModel[]>([]);
  const [result, setResultState] = useState<vehicleModel[]>([]);
  const [vehicles, setVehicleState] = useState<vehicleModel[]>([]);
  const [currentPage, setCurrentPage] = useState<number>(0);
  const [search, setSearch] = useState("");

  // Redux store'dan arama değerini alıyoruz.
  const searchElement: string = useSelector((state: RootState) => state.vehicleStore.search);

  const filterOptions: Array<SD_FilterTypes> = [
    SD_FilterTypes.NAME_A_Z,
    SD_FilterTypes.NAME_Z_A,
    SD_FilterTypes.PRICE_HIGH_LOW,
    SD_FilterTypes.PRICE_LOW_HIGH,
    SD_FilterTypes.RemoveFilter,
  ];

  const handleFilterClick = (sortTypes: any, pageIndex?: number) => {
    // Başlangıçta full listeyi kopyalıyoruz.
    let forSortArray = [...result];

    // Eğer parametre "Pagination" değilse, sıralama veya filtreleme yapıyoruz.
    if (sortTypes !== PAGINATION) {
      if (filterOptions[sortTypes] === SD_FilterTypes.PRICE_HIGH_LOW) {
        forSortArray.sort((a, b) => b.price - a.price);
      }
      if (filterOptions[sortTypes] === SD_FilterTypes.PRICE_LOW_HIGH) {
        forSortArray.sort((a, b) => a.price - b.price);
      }
      if (filterOptions[sortTypes] === SD_FilterTypes.NAME_A_Z) {
        forSortArray.sort((a, b) =>
          a.brandAndModel.toLowerCase().localeCompare(b.brandAndModel.toLowerCase())
        );
      }
      if (filterOptions[sortTypes] === SD_FilterTypes.NAME_Z_A) {
        forSortArray.sort((a, b) =>
          b.brandAndModel.toLowerCase().localeCompare(a.brandAndModel.toLowerCase())
        );
      }
      if (filterOptions[sortTypes] === SD_FilterTypes.RemoveFilter) {
        localStorage.removeItem("myFilter");
      } else {
        localStorage.setItem("myFilter", JSON.stringify(forSortArray));
      }
      // Filtre veya sıralama yapıldığında, sayfa numarasını sıfırlıyoruz.
      setCurrentPage(0);
    }

    // Eğer parametre "Pagination" ise, sayfa numarasını güncelliyoruz.
    if (sortTypes === PAGINATION) {
      setCurrentPage(pageIndex!);
    }

    // Sıralama işlemi veya pagination fark etmeksizin, gösterilecek öğeleri sayfalama ile belirliyoruz.
    const startIndex = (sortTypes === PAGINATION ? pageIndex! : 0) * ITEMS_PER_PAGE;
    const paginatedData = forSortArray.slice(startIndex, startIndex + ITEMS_PER_PAGE);
    setFilterResponse(paginatedData);
  };

  // Veriler geldikten sonra full dataset'i state'lere atıyoruz
  // ve ilk sayfa (ilk 8 öğe) görüntülensin diye pagination fonksiyonunu çağırıyoruz.
  useEffect(() => {
    if (data) {
      setVehicleState(data.result);
      setResultState(data.result);
      handleFilterClick(PAGINATION, 0);
    }
  }, [data]);

  // Arama (search) değiştiğinde, eğer bir arama terimi varsa tüm eşleşen veriyi (filtrelenmiş) gösteriyoruz.

  useEffect(() => {
    setSearch(searchElement);
    if (searchElement !== "") {
      const filtered = vehicles.filter((element) =>
        element.brandAndModel.toLowerCase().includes(searchElement.toLowerCase())
      );
      setFilterResponse(filtered);
    } else {
      // Arama boşsa, mevcut sayfa (currentPage) için pagination'ı yeniden uyguluyoruz.
      handleFilterClick(PAGINATION, currentPage);
    }
  }, [searchElement, vehicles, currentPage]);

  // Toplam sayfa sayısını hesaplıyoruz.
  const totalItems = result.length;
  const totalPages = Math.ceil(totalItems / ITEMS_PER_PAGE);
  const paginationButtons = Array.from({ length: totalPages }, (_, index) => index);

  return (
    <div className="container">
      <Banner />
      <div className="row">
        {/* Filtre menüsü */}
        <div className="dropdown mt-3">
          <button
            className="btn btn-secondary dropdown-toggle"
            type="button"
            data-bs-toggle="dropdown"
            aria-expanded="false"
          >
            Filter
          </button>
          <ul className="dropdown-menu">
            {filterOptions.map((filterTypes, index) => (
              <li key={index}>
                <a className="dropdown-item" onClick={() => handleFilterClick(index)}>
                  {filterTypes}
                </a>
              </li>
            ))}
          </ul>
        </div>

        {/* Araç kartları */}
        {filterResponse.map((vehicle, index) => (
          <div className="col" key={index}>
            <div className="auction-card text-center">
              <div className="card-image text-center">
                <img src={vehicle.image} alt={vehicle.brandAndModel} />
              </div>
              <div className="card-details text-center">
                <h2>{vehicle.brandAndModel}</h2>
                <p>
                  <strong>Year:</strong> {vehicle.manufacturingYear}
                </p>
                <p>
                  <strong>Color:</strong> {vehicle.color}
                </p>
                <p>
                  <strong>Current Bid:</strong> ${vehicle.price}
                </p>
                <p>
                  <strong>End Time:</strong> {vehicle.endTime}
                </p>
              </div>
              <div>
                <Link to={`Vehicle/VehicleId/${vehicle.vehicleId}`}>
                  <button className="btn btn-danger">Detail</button>
                </Link>
              </div>
              <Circle vehicle={vehicle} />
            </div>
          </div>
        ))}
      </div>

      {/* Sayfalama */}
      <nav aria-label="Page navigation example">
        <ul className="pagination">
          <li className="page-item">
            <a
              className="page-link"
              onClick={() => {
                if (currentPage > 0) {
                  handleFilterClick(PAGINATION, currentPage - 1);
                }
              }}
            >
              Previous
            </a>
          </li>
          {paginationButtons.map((page, index) => (
            <li className="page-item" key={index}>
              <a className="page-link" onClick={() => handleFilterClick(PAGINATION, page)}>
                {page + 1}
              </a>
            </li>
          ))}
          <li className="page-item">
            <a
              className="page-link"
              onClick={() => {
                if (currentPage < totalPages - 1) {
                  handleFilterClick(PAGINATION, currentPage + 1);
                }
              }}
            >
              Next
            </a>
          </li>
        </ul>
      </nav>
    </div>
  );
}

export default VehicleList;
