﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SalleRestaurant
    {
        //attributs
        private int id_rang;
        private int id_carre;
        private int id_zone;

        //methodes

        //setters
        public void setRang(int nrang)
        {
            id_rang = nrang;
        }

        public void setCarre(int ncarre)
        {
            id_carre = ncarre;
        }

        public void setSalleRestauration(int salleRestauraion)
        {
            id_zone = salleRestauraion;
        }

        //getters

        public int getRang()
        {
            return id_rang;
        }

        public int getCarre()
        {
            return id_carre;
        }
    }
}