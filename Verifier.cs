namespace knightmoves {
    public class Verifier {
        public bool taxExempt = false;
        public string state = "IA";
        public bool hasWheels = false;
        public bool canFly = false;
        public bool canSwim = false;


        public string Taxable(string state, bool taxExempt) {
            if(state == "IA" && !taxExempt){
                return "is taxable";
            }
            if(state == "IA" && taxExempt){
                return "";
            }
            if(state == "FL" && !taxExempt){
                return "";
            }
          
            return "";
        }

      
        public string IsVehicle(bool hasWheels, bool canFly, bool canSwim) {
            if(hasWheels || canFly || canSwim){
                return "is vehicle";
            }
            return "";
        }
    }
}
