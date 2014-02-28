using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WcfSampleService.Dto
{
    [DataContract]
    public class Datos
    {
        private int numero1;
        private float numero2;
        private String palabra1;

        [DataMember]
        public int Numero1
        {
            get { return numero1; }
            set { numero1 = value; }
        }

        [DataMember]
        public float Numero2
        {
            get { return numero2; }
            set { numero2 = value; }
        }

        [DataMember]
        public String Palabra1
        {
            get { return palabra1; }
            set { palabra1 = value; }
        }


    }
}
