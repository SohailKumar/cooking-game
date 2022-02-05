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
        this.beingCooked = 
    }
    
 
    public void GoDown()
    {
        MarioMovementState.GoDown();
        IsCrouch = true;
    }
    
    changeTheMenu(string nextMenu){
        this.mealsbeingCooked = nextMenu;
    }
    public void BeDead()
    {
        MarioPowerupState.BeDead();
        MarioMovementState.BeDead();

    }
    
    public void Update()
    {
        MarioSprite.Update();
        Physics.Update();
        if((this.location.X > GameObjectManager.Instance.EndOfLevelXPosition -MarioUtil.FlagpoleBuffer && this.location.X < GameObjectManager.Instance.EndOfLevelXPosition + MarioUtil.FlagpoleBuffer) && !hasCompletedLevel)
        {
            hasCompletedLevel = true;
            ScoringSystem.Instance.AddPointsForRestTime();
            if (MarioPowerupState is NormalMarioPowerupState)
                GameObjectManager.Instance.GameObjectList.SetSingleton(typeof(IMario),new SlideDownFlagDecorator(this, new Vector2(this.location.X, MarioUtil.HeightOfFloor)));
            else
                GameObjectManager.Instance.GameObjectList.SetSingleton(typeof(IMario), new SlideDownFlagDecorator(this, new Vector2(this.location.X, MarioUtil.HeightOfFloor-MarioUtil.MarioHeight)));

            atTheEnd = true;
        }
        if (isOnPipe)
        {
            location.Y++;
        }
    }
    
    
    public void SetIsLand(bool land)
    {
        if (land)
            Island = true;
        else
            Island = false;
    }
         

    public bool IsJump()
    {
        if (MarioMovementState is LeftJumpingMarioMovementState||
            MarioMovementState is RightJumpingMarioMovementState)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}