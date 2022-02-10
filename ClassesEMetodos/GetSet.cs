﻿using System;

namespace CursoCSharp.ClassesEMetodos
{

    public class Moto
    {
        private string Marca;
        private string Modelo;
        private uint Cilindrada; // obriga a passar valor positivo

        public Moto(string marca, string modelo, uint cilindrada)
        {
            //    Marca = marca;
            //    Modelo = modelo;
            //    Cilindrada = cilindrada;
            SetMarca(marca);
            SetModelo(modelo);
            SetCilindrada(cilindrada);
        }

        public Moto()
        {

        }
        public string GetMarca()
        {
            return Marca;
        }
        public void SetMarca(string marca)
        {
            Marca = marca;
        }
        public string GetModelo()
        {
            return Modelo;
        }

        public void SetModelo(string modelo)
        {
            Modelo = modelo;
        }
        public uint GetCilindrada()
        {
            return Cilindrada;
        }

        public void SetCilindrada(uint cilindrada)
        {
             // 1 opção
            //if (cilindrada > 0) // validação para nao aceitar valores negativos
            //{
            //    Cilindrada = cilindrada;
            //}
            // 2 opçõa
            //Cilindrada = Math.Abs(cilindrada);

            Cilindrada = cilindrada;
        }
    }
    class GetSet
    {
        public static void Executar()
        {
            var moto1 = new Moto("Kawasaki", "Ninja ZX-6R", 636);
            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());

            var moto2 = new Moto();
            moto2.SetMarca("Honda");
            moto2.SetModelo("CG Titan");
            moto2.SetCilindrada(150);
            Console.WriteLine(moto2.GetMarca() + " " + moto2.GetModelo());
            Console.WriteLine(moto2.GetCilindrada());

        }
    }
}
