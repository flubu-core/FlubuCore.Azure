
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Reservations;

namespace FlubuCore.Azure
{
    public class Reservations
    {
        
        
            public AzureReservationsCatalogTask ReservationsCatalog()
            {
                return new AzureReservationsCatalogTask();
            }

            public AzureReservationsReservationOrderIdTask ReservationsReservationOrderId()
            {
                return new AzureReservationsReservationOrderIdTask();
            }

            public AzureReservationsReservationOrderTask ReservationsReservationOrder()
            {
                return new AzureReservationsReservationOrderTask();
            }

            public AzureReservationsReservationTask ReservationsReservation()
            {
                return new AzureReservationsReservationTask();
            }

            public AzureReservationsReservationMergeTask ReservationsReservationMerge(string reservationId1 ,  string reservationId2 ,  string reservationOrderId)
            {
                return new AzureReservationsReservationMergeTask(reservationId1,  reservationId2,  reservationOrderId);
            }

            public AzureReservationsReservationSplitTask ReservationsReservationSplit(string quantity1 ,  string quantity2 ,  string reservationId ,  string reservationOrderId)
            {
                return new AzureReservationsReservationSplitTask(quantity1,  quantity2,  reservationId,  reservationOrderId);
            }

            public AzureReservationsReservationUpdateTask ReservationsReservationUpdate(string appliedScopeType ,  string reservationId ,  string reservationOrderId)
            {
                return new AzureReservationsReservationUpdateTask(appliedScopeType,  reservationId,  reservationOrderId);
            }
        
    }
}

