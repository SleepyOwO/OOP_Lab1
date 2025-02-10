namespace OOP_Lab1.MyClass {
    
    public class InternetOp {
        
        private string _name;
        private string _region;
        private int _price;
        private int _abonentCount;
        private double _age;
        private bool _benefits;
        private bool _supports5g;

        public InternetOp() {

            _name = "unset";
            _region = "unset";
            _price = 0;
            _abonentCount = 0;
            _age = 0;
            _benefits = false;
            _supports5g = false;

        }

        public InternetOp(string name) {

            _name = name;
            _region = "unset";
            _price = 0;
            _abonentCount = 0;
            _age = 0;
            _benefits = false;
            _supports5g = false;

        }
        
        public InternetOp(string name, int price) {

            _name = name;
            _region = "unset";
            _price = price;
            _abonentCount = 0;
            _age = 0;
            _benefits = false;
            _supports5g = false;

        }
        
        public InternetOp(string name, string region, int price, int abonentCount, 
            double age, bool benefits, bool supports5g) {

            _name = name;
            _region = region;
            _price = price;
            _abonentCount = abonentCount;
            _age = age;
            _benefits = benefits;
            _supports5g = supports5g;

        }

        public override string ToString()
        {
            return "name: " + _name + "\r\nregion: " + _region + "\r\nprice: " + _price + 
                   "\r\nabonent count: " + _abonentCount + "\r\nage: " + _age + "\r\nbenefints: " + _benefits +
                   "\r\n5G support: " + _supports5g;
        }
        
        
    }
}