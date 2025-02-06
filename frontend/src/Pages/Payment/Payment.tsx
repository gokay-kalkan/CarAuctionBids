import React, { useState } from 'react'
import { useLocation } from 'react-router-dom';
import Loader from '../../Helper/Loader';
import { loadStripe } from '@stripe/stripe-js';
import CheckoutForm from './CheckoutForm';
import { Elements } from '@stripe/react-stripe-js';
import { Modal } from 'react-bootstrap';

function Payment() {
    const location = useLocation()
    const {apiResult,userStore} = location.state    
    const [show,setShow] = useState(true);

    const stripePromise = loadStripe("pk_test_51QYtsqGMRzQl1BawUwyLWkXq6JiM5XUZZWxGR71eCLEkdUJpuPKTQ4VGh8UPTF9bDkHYI2JNCDzvwbYFS5HekRlS00R0NBVV6N")
    if (apiResult) {
        const options = {
            clientSecret : apiResult.clientSecret
        }
  return (
    <div>
       <Elements stripe={stripePromise} options={options} >


       <div className='container m5 p-5' >
        <div className='row' >
         <Modal show={show}>

            <div className=' container' >
                <CheckoutForm></CheckoutForm>
            </div>
         </Modal>

        </div>
    </div>
       </Elements>
    </div>
  )
}

else {
    return (
        <Loader></Loader>
    )
}
}

export default Payment
