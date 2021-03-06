﻿using System;

namespace Arex388.SunriseSunset.Models {
	public sealed class Request {
		public DateTime DateOn { get; set; }
		public string Endpoint => $"https://api.sunrise-sunset.org/json?lat={Latitude}&lng={Longitude}&date={DateOn:yyyy-MM-dd}&formatted=0";
		public decimal Latitude { get; set; }
		public decimal Longitude { get; set; }
	}
}