using OtelFinder.Entities.Concrete;
using OtelFinder.Repositories.Abstract;
using OtelFinder.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelFinder.Repositories.Concrete
{
    public class ReservationRepository : BaseReservationRepository, IListOtel, IListReservation
    {
        public override void CreateReservation(int id, Customer customer, Otel otel)
        {
            Reservation reservation = new Reservation();
            reservation.Id = id;
            customer.Name = customer.Name;
            customer.Surname = customer.Surname;
            otel.OtelName = otel.OtelName;
            otel.Location = otel.Location;
            otel.Picture = otel.Picture;
            otel.Price = otel.Price;
        }

        public override void DeleteOtel(int id)
        {
            foreach (var item in SeedData.reservations)
            {
                if (item.Id == id)
                {
                    SeedData.reservations.Remove(item);
                }
            }
        }

        public List<Reservation> ListReservations()
        {
            return SeedData.reservations.ToList();
        }

        public void ListOtelsLocation(ComboBox cmbLocation)
        {
            foreach (var item in SeedData.otels)
            {
                cmbLocation.Items.Add(item.OtelName);

            }
        }

        public void FillReservation(ComboBox cmbLocation, Label lblOtelName,Label lblLocation,Label lblPrice)
        {
            foreach (var item in SeedData.otels)
            {
                if (item.OtelName==cmbLocation.Text)
                {
                    lblOtelName.Text = item.OtelName;
                    lblLocation.Text = "İstanbul";
                    lblPrice.Text = item.Price.ToString();
                }
            }
            
        }

    }
}
