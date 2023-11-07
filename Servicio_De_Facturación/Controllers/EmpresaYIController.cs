using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace Servicio_De_Facturación.Controllers
{
}
    public class EmpresaYIController : ControllerBase{

        // Se realiza arreglo
    
        public Factura[] DatosEmpresa = new Factura[]{

            new Factura{id= 1, NombreCliente= "Juan", ApellidoCliente= "Pérez", EdadCliente= 30, RutCliente= "14570441-k", NombreEmpresa= "Inversiones Sepa LTA", RutEmpresa= "77888009-1", GiroEmpresa= "Ganaderia", TotalVentas= 300, MontoVentas= 3000000, MontoIVA= 570000, MontoUtilidades= 2430000 },
            new Factura{id= 2, NombreCliente= "Maria", ApellidoCliente= "López", EdadCliente= 35, RutCliente= "18570441-2", NombreEmpresa= "Auto Lana SPA", RutEmpresa= "77888009-9", GiroEmpresa= "Ventas de Autos", TotalVentas= 300, MontoVentas= 3000000, MontoIVA= 570000, MontoUtilidades= 2430000  },
            new Factura{id= 1, NombreCliente= "Rosa", ApellidoCliente= "Mora", EdadCliente= 40, RutCliente= "24570441-8", NombreEmpresa= "Legales SPA", RutEmpresa= "77888023-2", GiroEmpresa= "Asesoria Legal", TotalVentas= 300, MontoVentas= 3000000, MontoIVA= 570000, MontoUtilidades= 2430000 }}; 
        

            //Genero Consultor
        
            [HttpGet]
            [Route("Datos solicitados 3 Empresas")]

        
            public IActionResult Listar(){

    try {

            if (DatosEmpresa != null){
              for (int x =0; x < DatosEmpresa.Length; x++){
              
                Console.WriteLine(DatosEmpresa[x]);
            }
            //imprimo code 200 que es correcto
            return StatusCode(200, DatosEmpresa);

            }else{
                return StatusCode (401, "No se encontraron datos");
            }

            

    }catch (Exception ){
     
            return StatusCode (401, "No se encontraron datos");

    }
}


        
//realizo un consultor para llamar todos los datos de una empresa en particular por medio de su ID
        [HttpGet]
        [Route("Datos de una sola empresa por su Id")]

        public IActionResult ListarEmpresa(int id){

            try{

                if(id > 0 && id <=DatosEmpresa.Length){
                    //imprimimos el status code 200 que es correcto
                    return StatusCode(200,DatosEmpresa[id-1]);


                }else{
                    // se imprime error 
                    return StatusCode(401,"No se ha encontrado la Empresa");
                }

            }catch(Exception ex){
                // se imprime error 
                return StatusCode(500, "Error interno por :"+ex);

            }
        }

        
//se realiza un generador para crear y guardar nuevos registros 
      [HttpPost]
      [Route("Crear Nueva Empresa")]

      public IActionResult Guarda([FromBody] Factura empresaYI){

        try{
            //imprimimos el status code 200 que es correcto
            return StatusCode(200, DatosEmpresa);

        }catch(Exception ex){
            //imprimimos que no se pudo crear la empresa
            return StatusCode(400, "No se pudo crear la Empresa por: "+ex);

        }

      } 


     [HttpPut]
    [Route("Editar datos de una Empresa por su Id")]

    public IActionResult  Editar_Empresa(int id, [FromBody] Factura EmpresaYI){

        //se crea elemento de control para recorrer el arreglo
        if (id > 0 && id <= DatosEmpresa.Length){

            //procedo a la edicion de la Empresa
                DatosEmpresa[id-1].NombreCliente= EmpresaYI.NombreCliente;
                DatosEmpresa[id-1].ApellidoCliente = EmpresaYI.ApellidoCliente;
                DatosEmpresa[id-1].EdadCliente =EmpresaYI.EdadCliente;
                DatosEmpresa[id-1].RutCliente =EmpresaYI.RutCliente;
                DatosEmpresa[id-1].NombreEmpresa =EmpresaYI.NombreEmpresa;
                DatosEmpresa[id-1].RutEmpresa = EmpresaYI.RutEmpresa;
                DatosEmpresa[id-1].GiroEmpresa = EmpresaYI.GiroEmpresa;
                DatosEmpresa[id-1].TotalVentas = EmpresaYI.TotalVentas;
                DatosEmpresa[id-1].MontoVentas = EmpresaYI.MontoVentas;
                DatosEmpresa[id-1].MontoIVA= EmpresaYI.MontoIVA;
                DatosEmpresa[id-1].MontoUtilidades = EmpresaYI.MontoUtilidades;

        
            //imprimimos el status code 200 que es correcto
            return StatusCode(200, DatosEmpresa[id-1]);

        }else if(id==0){

            //imprimimos en consola que no se encontro la persona
            Console.WriteLine("Empresa No encontrada");
            return StatusCode(404);


        }else{

 //imprimimos que no se pudo editar la persona
            Console.WriteLine("No se pudo editar la empresa");
            return StatusCode(400);

        }



    }



//se realiza un consultor para eliminar un registro por medio de su ID
    [HttpDelete]
    [Route("Eliminar una empresa por su Id")]

    public IActionResult ElimniarEmpresa(int id){

        try{

            if(id >0 && id <= DatosEmpresa.Length){

                DatosEmpresa[id-1] = null;
                // se imprime exito en eliminar
                return StatusCode(200, "Se ha eliminado el registro con EXITO!");

            }else{
                // se imprime error de eliminar registro
                return StatusCode(401, "No se pudo borrar el registro o no existe");

            }


        }catch(Exception ex){
            // se imprime error de eliminar registro
            return StatusCode(500, "No se pudo borrar por: "+ex);

        }

    } 

        }
    
