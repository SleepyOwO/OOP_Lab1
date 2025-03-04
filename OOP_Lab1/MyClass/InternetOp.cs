namespace OOP_Lab1.MyClass {
    
    public class InternetOp {

        private static int _objCount = 0;
        
        private string _name;
        private string _region;
        private int _price;
        private int _abonentCount;
        private double _age;
        private bool _benefits;
        public bool _supports5g;

        public InternetOp() {

            _name = "unset";
            _region = "unset";
            _price = 0;
            _abonentCount = 0;
            _age = 0;
            _benefits = false;
            _supports5g = false;
            _objCount++;

        }

        public InternetOp(string name) {

            _name = name;
            _region = "unset";
            _price = 0;
            _abonentCount = 0;
            _age = 0;
            _benefits = false;
            _supports5g = false;
            _objCount++;
            
        }
            
        public InternetOp(string name, int price) {

            _name = name;
            _region = "unset";
            _price = price;
            _abonentCount = 0;
            _age = 0;
            _benefits = false;
            _supports5g = false;
            _objCount++;

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
            _objCount++;
        }

        public override string ToString() {
            return "Name: " + _name + "\r\nRegion: " + _region + "\r\nPrice: " + _price + 
                   "\r\nAbonent count: " + _abonentCount.ToString("X") + "\r\nAge: " + _age + "\r\nBenefits: " + _benefits +
                   "\r\n5G support: " + _supports5g;
        }

        public void setName(string name) {
            _name = name;
        }
        
        public string getName() {
            return _name;
        }

        public void setRegion(string region) {
            _region = region;
        }
        
        public string getRegion() {
            return _region;
        }

        public void setPrice(int price) {
            _price = price;
        }
        
        public int getPrice() {
            return _price;
        }
        
        public void setAbonentCount(int ab_count) {
            _abonentCount = ab_count;
        }

        public int getAbonentCount() {
            return _abonentCount;
        }

        public void setAge(double age) {
            _age = age;
        }
        
        public double getAge() {
            return _age;
        }

        public void setBenefits(bool benefits) {
            _benefits = benefits;
        }
        
        public bool getBenefits() {
            return _benefits;
        }
        
        public void set5gSupport(bool supports) {
            _supports5g = supports;
        }

        public bool get5gSupport() {
            return _supports5g;
        }
        
    }
}