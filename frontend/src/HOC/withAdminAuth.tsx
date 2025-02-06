import React from 'react'

import { jwtDecode } from 'jwt-decode';
import { SD_ROLES } from '../interfaces/enums/SD_ROLES';
import userModel from '../interfaces/userModel';



const withAdminAuth = (WrappedComponent:any)  => {
        return(props:any) => {
            const token = localStorage.getItem("token");
            if (token!=null) {
                const decode : userModel = jwtDecode(token);
                if (decode.role !== SD_ROLES.Administrator) {
                    window.location.replace("/accessDenied");
                    return null;
                }
            }
            else {
                window.location.replace("/login")
                return null;
            }
            return <WrappedComponent {...props} ></WrappedComponent>
        } 
}



export default withAdminAuth