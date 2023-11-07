//Implemento los metodos para gestionar la facturación

    public class Factura {
   
         public int id { get; set; }
         public string? NombreCliente { get; set; }
        public string? ApellidoCliente { get; set; }
        public int EdadCliente { get; set; }
        public string? RutCliente { get; set; }
        public string? NombreEmpresa { get; set; }
        public string? RutEmpresa { get; set; }
         public string? GiroEmpresa { get; set; }
        public decimal TotalVentas { get; set; }
        public decimal MontoVentas { get; set; }
        public decimal MontoIVA { get; set; }
        public decimal MontoUtilidades { get; set; }


        
    }

