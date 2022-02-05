public class applianceState : monoBehavior
{
    private Vector2 location = Vector2.Zero;
    
    private int maxCapacity;
    private string ApplianceType;
    private string mealsbeingCooked;
    private bool beingCooked = true;
    
    public applianceState(Vector2 location, string type)
    {
        this.location = location;
        this.ApplianceType = type;

    }
    public void beingCooked()
    {
 
    }
    
 
    public void GoDown()
    {
        MarioMovementState.GoDown();
        IsCrouch = true;
    }
    
    changeTheMenu(string nextMenu){
        this.mealsbeingCooked = nextMenu;
    }

    
    public void Update()
    {
        
        
    }
    
    
}