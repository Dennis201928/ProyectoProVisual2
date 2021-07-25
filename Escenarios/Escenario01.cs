using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Escenarios.Escenario;
using Modelo.Escuela;
using Modelo;

namespace Escenarios
{
    public class Escenario01 : Escenario, IEscenario
    {

        public float CalIva = 0f;
        public Dictionary<ListaTipo, IEnumerable<IDBEntity>> carga()
        {
            //Creación de marca
            marca G220 = new() { nommarca = "G220" };
            marca Mt500 = new() { nommarca = "Mt500" };
            marca Rtx5000 = new() { nommarca = "Rtx5000" };
            marca Otr800 = new() { nommarca = "Otr800" };
            List<marca> lstMarca = new() { G220, Mt500, Rtx5000, Otr800 };
            datos.Add(ListaTipo.marca, lstMarca);

            //Creación de modelos
            modelo Giulietta = new() { nombre_modelo = "Giulietta", color = "Negro", npuertas = 4 };
            modelo MiTo = new() { nombre_modelo = "MiTo", color = "Azul", npuertas = 4 };
            modelo DB9 = new() { nombre_modelo = "DB9", color = "Verde", npuertas = 4 };
            modelo ABARTH = new() { nombre_modelo = "ABARTH", color = "Morado", npuertas = 4 };
            List<modelo> lstModelo = new() { Giulietta, MiTo, DB9, ABARTH };
            datos.Add(ListaTipo.modelo, lstModelo);

            //Creación de carros
            carro Fiat = new() { modelo= Giulietta,marca= G220 };
            carro Chevrolet = new() { modelo = MiTo, marca = Mt500 };
            carro Lexus = new() { modelo = DB9, marca = Rtx5000 };
            carro Opel = new() { modelo = ABARTH, marca = Otr800 };
            List<carro> lstCarros = new() { Fiat,Chevrolet,Lexus,Opel };
            datos.Add(ListaTipo.carro, lstCarros);


            //Configuracion
            Configuracion configuracion = new()
            {
                valormin = 15000,


            };
            List<Configuracion> lstConfig = new() { configuracion };
            datos.Add(ListaTipo.configuracion, lstConfig);

            //Creación de genero
            genero Masculino = new() { nomgenero = "Masculino" };
            genero Fenenino = new() { nomgenero = "Fenenino" };

            List<genero> lstgenero = new() { Masculino, Fenenino };
            datos.Add(ListaTipo.genero, lstgenero);


            //Creación de cliente
            cliente Alverto = new() { nombre= "Alverto", edad = 35 , genero= Masculino };
            cliente Melissa = new() { nombre = "Melissa", edad = 45, genero = Fenenino };
            cliente Karen = new() { nombre = "Jose", edad = 25, genero = Fenenino };
            cliente Josue = new() { nombre = "Josue", edad = 42, genero = Masculino };
            List<cliente> lstClientes = new() { Alverto, Melissa, Karen, Josue };
            datos.Add(ListaTipo.cliente, lstClientes);

         

            //Creación de tipopago
            tipopago Efectivo = new() { nombreTipoPago = "Efectivo" };
            tipopago Cheque = new() { nombreTipoPago = "Cheque" };
            List<tipopago> lsttipopago = new() { Efectivo, Cheque };
            datos.Add(ListaTipo.tipopago, lsttipopago);


            //Creación de iva

            //iva im_sali_divisas = new() { im_sali_divisas = 0.5f };
            //iva im_val_agregado = new() { im_val_agregado = 0.12f };
            //iva arancel = new() { arancel = 0.40f };
            //iva imrodaje = new() { imrodaje = 5.00f };
            //iva im_sali_divisas_isd = new() { im_sali_divisas_isd = 5.0f };

            //List<iva> lstiva = new() { im_sali_divisas, im_val_agregado, arancel, imrodaje, im_sali_divisas_isd };
            //datos.Add(ListaTipo.iva, lstiva);



            iva sumaiva = new()
            {
                im_sali_divisas = 0.5f,
                im_val_agregado = 0.12f,
                arancel = 0.40f,
                imrodaje = 5.00f,
                im_sali_divisas_isd = 5.0f,
            };

            List<iva> lstIva = new() { sumaiva };
            datos.Add(ListaTipo.iva, lstIva);


            //Creación de venta
            venta venta1 = new() {
                cliente = Alverto,
                carro = Fiat,
                tipopago = Cheque,
                precio = 4200,
                iva = sumaiva,
                total = 4200 + sumaiva.TotalIva,
                Estado= "Deviendo"


            };
            venta venta2 = new() {
                cliente = Melissa,
                carro = Chevrolet,
                tipopago=Efectivo,
                precio = 1200,
                iva = sumaiva,
                total = 1200 + sumaiva.TotalIva,
                Estado = "Pagado"

            };
            venta venta3 = new() {
                cliente = Karen,
                carro = Lexus,
                tipopago = Cheque,
                precio = 1400,
                iva = sumaiva,
                total = 1400 + sumaiva.TotalIva,
                Estado = "Deviendo"

            };
            venta venta4 = new() {
                cliente = Josue,
                carro = Opel,
                tipopago = Efectivo,
                precio = 3500,
                iva = sumaiva,
                total = 3500 + sumaiva.TotalIva,
                Estado = "Pagado"

            };
            List<venta> lsventa = new() { venta1,venta2,venta3,venta4 };
            datos.Add(ListaTipo.venta, lsventa);

             return datos;
        }

       
    }
}

















//            Jornada JMatutina = new Jornada()
//            {
//                TipoJornada = "Matutina",
//                dias = "Lunes a Viernes",
//                HoraIncio = "7:00 a.m",
//                HoraFinal = "13:00 p.m"
//            };
//            Jornada JVespertina = new Jornada()
//            {
//                TipoJornada = "Vespertina",
//                dias = "Lunes a Viernes",
//                HoraIncio = "13:00 p.m",
//                HoraFinal = "19:00 p.m"
//            };
//            Jornada JNocturna = new Jornada()
//            {
//                TipoJornada = "Nocturna",
//                dias = "Lunes a Viernes",
//                HoraIncio = "16:30 p.m",
//                HoraFinal = "22:00 p.m"
//            };
//            Jornada JIntensiva = new Jornada()
//            {
//                TipoJornada = "Intensiva",
//                dias = "Lunes a Viernes",
//                HoraIncio = "14:00 p.m",
//                HoraFinal = "16:00 p.m"
//            };
//            Jornada JEjecutiva = new Jornada()
//            {
//                TipoJornada = "Intensiva",
//                dias = "Sabados",
//                HoraIncio = "8:00 a.m",
//                HoraFinal = "16:00 p.m"
//            };
//            List<Jornada> lstJornada = new() { JMatutina, JNocturna, JVespertina, JIntensiva, JEjecutiva };
//            datos.Add(ListaTipo.Jornadas, lstJornada);
//            //Registro de los cursos
//            Curso N2D_2020PAO2_Disenio = new Curso()
//            {
//                Materia = matDisenio,
//                FechaInicio = new DateTime(2020, 5, 1),
//                FechaFin = new DateTime(2020, 6, 30),
//                Jornada = JMatutina,
//                Nombre = "Nivel 2 Diurna de Diseño Web",
//                Periodo = per2020_PAO2
//            };
//            Curso N2D_2020PAO2_AdminDB = new Curso()
//            {
//                Periodo = per2020_PAO2,
//                Materia = matAdminDB,
//                Jornada = JVespertina,
//                Nombre = "Nivel 2 Diurno de Administración BBDD",
//                FechaInicio = new DateTime(2020, 5, 1),
//                FechaFin = new DateTime(2020, 6, 15)
//            };
//            Curso N3D_2021PAO1_LogProg = new Curso()
//            {
//                Periodo = per2021_PAO1,
//                Materia = matLogProg,
//                Jornada = JMatutina,
//                Nombre = "Nivel 3 Diurno de Lógica de Programación",
//                FechaInicio = new DateTime(2020, 11, 1),
//                FechaFin = new DateTime(2021, 1, 30)
//            };
//            Curso N3D_2021PAO1_ProdDig = new Curso()
//            {
//                Periodo = per2021_PAO1,
//                Materia = matProdDig,
//                Jornada = JNocturna,
//                Nombre = "Nivel 3 Diurno de Productos Digitales",
//                FechaInicio = new DateTime(2020, 2, 10),
//                FechaFin = new DateTime(2021, 3, 28)
//            };
//            Curso N3D_2021PAO1_VideoMk = new Curso()
//            {
//                Periodo = per2021_PAO1,
//                Materia = matVideoMk,
//                Jornada = JMatutina,
//                Nombre = "Nivel 3 Diurno de Video Marketing",
//                FechaInicio = new DateTime(2020, 4, 7),
//                FechaFin = new DateTime(2021, 6, 8)
//            };
//            Curso N4D_2021PAO2_ProgWeb = new Curso()
//            {
//                Periodo = per2021_PAO2,
//                Materia = matProgWeb,
//                Jornada = JNocturna,
//                Nombre = "Nivel 4 Diurno de Programación Web",
//                FechaInicio = new DateTime(2021, 11, 1),
//                FechaFin = new DateTime(2021, 12, 21)
//            };
//            Curso N4D_2021PAO2_Elearng = new Curso()
//            {
//                Periodo = per2021_PAO2,
//                Materia = matELearng,
//                Jornada = JIntensiva,
//                Nombre = "Nivel 4 Diurno de E-Learning",
//                FechaInicio = new DateTime(2022, 1, 4),
//                FechaFin = new DateTime(2022, 2, 27)
//            };
//            List<Curso> lstCursos = new() {
//                N2D_2020PAO2_AdminDB, N2D_2020PAO2_Disenio,
//                N3D_2021PAO1_LogProg, N3D_2021PAO1_ProdDig, N3D_2021PAO1_VideoMk,
//                N4D_2021PAO2_Elearng, N4D_2021PAO2_ProgWeb
//            };

//            datos.Add(ListaTipo.Cursos,lstCursos);

//            //Retorno el diccionario
//            return datos;
//        }
//    }
//}
