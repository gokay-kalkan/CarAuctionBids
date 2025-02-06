import React, { useEffect, useState } from 'react'
import { useGetVehiclesQuery } from '../../Api/vehicleApi'
import Loader from '../../Helper/Loader';

import "./Styles/Vehicle.css"

import { Link,NavLink } from 'react-router-dom';
import { vehicleModel } from '../../interfaces/vehicleModel';
import RemoveVehicle from './RemoveVehicle';
function Vehicle() {

    const {data,isLoading} = useGetVehiclesQuery(null);
    const [vehicleData,setVehicleDataState] = useState<vehicleModel[]>([]);


    useEffect(()=>{
     
        if (data) {
            if (data.result) {
                console.log(vehicleData);
                setVehicleDataState(data.result);
    
            }
        }
       
    },[data])



    if (!data) {
        <Loader></Loader>
    }


  return (
    <div>
        <div className='text-center' >
            <div className='text-center' >
                
                    <Link to={"/Admin/CreateVehicle"} >
                        <a className='btn btn-warning' type='button' > Create Vehicle </a>
                    </Link>
            </div>
            
            <table>
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Vehicle Name</th>
                        <th>Price</th>
                        <th>Auction Price</th>
                        <th>Manufacturing Year</th>
                        <th>Image</th>
                        <th>Activities</th>
                    </tr>
                </thead>

                <tbody>
                            {
                                vehicleData.map((vehicle:vehicleModel,index:number) => (
                                    <>
                                        <tr key={vehicle.vehicleId || index}>
                                        <td>{index + 1}</td>
                                            <td> {vehicle.brandAndModel} </td>
                                            <td> {vehicle.price} </td>
                                            <td> {vehicle.auctionPrice} </td>
                                            <td> {vehicle.manufacturingYear} </td>
                                            <img style={{width:"200px",height:"220px"}} src={vehicle.image} ></img>
                                            <td> 
                                            <RemoveVehicle vehicleId = {vehicle.vehicleId} ></RemoveVehicle>
                                              
                                                 </td>

                                                 <td>
                                                <Link to={ `/Admin/CreateVehicle/${vehicle.vehicleId}` } >
                                                 <a className='btn btn-warning'  ><i className="bi bi-pen"></i></a>

                                                </Link>
                                                 </td>
                                        </tr>
                                    
                                    </>
                                ))
                            }
                </tbody>



            </table>
        </div>
    </div>
  )
}

export default Vehicle