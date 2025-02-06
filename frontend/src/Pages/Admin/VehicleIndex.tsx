import React from 'react'
import { withAdminAuth } from '../../HOC'
import Vehicle from './Vehicle'

function VehicleIndex() {
  return (
    <div>
          <Vehicle/>
    </div>
  )
}

export default withAdminAuth(VehicleIndex) 