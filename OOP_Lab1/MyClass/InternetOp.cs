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

        public override string ToString() {
            return "Name: " + _name + "\r\nRegion: " + _region + "\r\nPrice: " + _price + 
                   "\r\nAbonent count: " + _abonentCount + "\r\nAge: " + _age + "\r\nBenefits: " + _benefits +
                   "\r\n5G support: " + _supports5g;
        }


        public string getName() {
            return _name;
        }

        public string getRegion() {
            return _region;
        }

        public int getPrice() {
            return _price;
        }

        public int getAbonentCount() {
            return _abonentCount;
        }

        public double getAge() {
            return _age;
        }

        public bool getBenefits() {
            return _benefits;
        }

        public bool get5gSupport() {
            return _supports5g;
        }
        
    }
}