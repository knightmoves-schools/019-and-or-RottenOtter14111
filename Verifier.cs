namespace knightmoves;
public class Verifier
{
    // Add your code here
    public bool taxExempt = false;
    public string state = "IA";
    public bool hasWheels = false;
    public bool canFly = false;
    public bool canSwim = false;
    public string Taxable(state taxExempt){
        if(state == "IA" && taxExempt == false){
            return "is taxable";
        }
        if(state == "IA" && taxExempt == true){
            return "";
        }
        if(state == "FL" && taxExempt == false){
            return "";
        }
    }
}
public string isVehicle(hasWheels canFly canSwim){
    if(hasWheels == true || canFly == true || canSwim == true){
        return "is vehicle";
    }
    if(hasWheels == true && canFly == false && canSwim == false){
        return "is vehicle";
    }
    if(hasWheels == false && canFly == true && canSwim == false){
        return "is vehicle";
    }
    if(hasWheels == false && canFly == false && canSwim == true){
        return "is vehicle";
    }
    if(hasWheels == false && canFly == true && canSwim == true){
        return "is vehicle";
    }
    if(hasWheels == false && canFly == false && canSwim == true){
        return "";
    }
    
}

