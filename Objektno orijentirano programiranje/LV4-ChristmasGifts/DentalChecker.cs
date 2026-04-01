

public class DentalChecker : NaughtinessCheck
{
    public bool isNaughty(Kid kid)
    {
        return !kid.brushingTeethRegularly;
    }
}
