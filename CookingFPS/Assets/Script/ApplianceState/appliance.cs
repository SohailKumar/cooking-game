abstract class appliance
{

    bool check;
    

    public abstract int startCooking(Meal meal);
    public abstract int completeCooking(Meal meal);
    public abstract int beingCooked(bool check);
    public abstract string changeTheMenu(string nextMeal);






}