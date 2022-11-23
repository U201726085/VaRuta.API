﻿using VaRuta.API.Routing.Domain.Models;

namespace VaRuta.API.Booking.Domain.Models;

public class Consignees
{

    public int Id { get; set; }
    
    public string Name { get; set; }
    
    public string Dni { get; set; }

    public string Address { get; set; }
    public List<Shipment> Shipments { get; set; }
}