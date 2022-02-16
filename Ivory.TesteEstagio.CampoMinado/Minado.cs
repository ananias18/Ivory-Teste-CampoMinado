 class Minado
    {
        bool bomba = false;
        bool aberta = false;
        int valor = 0;

        Minado[,] casa;


        public Minado()
        {

        }

        public void setBombas()
        {
            bomba = true;

        }

        public bool getBombas()
        {
            return bomba;
        }

        public bool getAberta()
        {
            return aberta;
        }

        public void setAberta()
        {
            aberta = true;
        }

        public void setValor()
        {
            valor++;
        }

        public int getValor()
        {
            return valor;
        }
    }