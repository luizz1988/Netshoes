using Imposto.Core.Domain.Imposto.MG;
using Imposto.Core.Domain.Imposto.SP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imposto.Core.Domain.Imposto
{
   public class CalculaCfop
    {

       public string ObtemCfop(Pedido pedido)
       {

           //===== SP ==========
           ImpostoCfop cfop1 = new CfopSpRj();
           ImpostoCfop cfop2 = new CfopSpPe();
           ImpostoCfop cfop3 = new CfopSpMg();
           ImpostoCfop cfop4 = new CfopSpPb();
           ImpostoCfop cfop5 = new CfopSpPr();
           ImpostoCfop cfop6 = new CfopSpPi();
           ImpostoCfop cfop7 = new CfopSpRo();
           ImpostoCfop cfop8 = new CfopSpSe();
           ImpostoCfop cfop9 = new CfopSpTo();
           ImpostoCfop cfop10 = new CfopSpPa();
           ImpostoCfop cfop11 = new CfopSpRj();

           //===== RJ ==========
           ImpostoCfop cfop12 = new CfopMgRj();
           ImpostoCfop cfop13 = new CfopMgPe();
           ImpostoCfop cfop14 = new CfopMgPb();
           ImpostoCfop cfop15 = new CfopMgPr();
           ImpostoCfop cfop16 = new CfopMgPi();
           ImpostoCfop cfop17 = new CfopMgRo();
           ImpostoCfop cfop18 = new CfopMgSe();
           ImpostoCfop cfop19 = new CfopMgTo();
           ImpostoCfop cfop20 = new CfopMgPa();
           ImpostoCfop semCfop = new SemCfop();

           cfop1.Proximo = cfop2;
           cfop2.Proximo = cfop3;
           cfop3.Proximo = cfop4;
           cfop4.Proximo = cfop5;
           cfop5.Proximo = cfop6;
           cfop6.Proximo = cfop7;
           cfop7.Proximo = cfop8;
           cfop8.Proximo = cfop9;
           cfop9.Proximo = cfop10;
           cfop10.Proximo = cfop11;
           cfop11.Proximo = cfop12;
           cfop12.Proximo = cfop13;
           cfop13.Proximo = cfop14;
           cfop14.Proximo = cfop15;
           cfop15.Proximo = cfop16;
           cfop16.Proximo = cfop17;
           cfop17.Proximo = cfop18;
           cfop18.Proximo = cfop19;
           cfop19.Proximo = cfop20;
           cfop20.Proximo = semCfop;

           return cfop1.ObtemCfop(pedido);
       
       
       }

    }
}
