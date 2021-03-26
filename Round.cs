public class Roudns : MonoBehaviour
{
    // Vaiables

    public Text Roundtxt;
    public AudioSource audioSource;
    [SerializeField]private string Roundstring;
    [SerializeField]private float NextRoundTime;

    private float CurrentRound;
    private float CurrentTime = 0;
    
    //////////////////////////////////
    
    private void Update()
    {
        Roundtxt.text = Roundstring + CurrentRound;
        CurrentTime += Time.deltaTime;
        NextRound();
    }

    //////////////////////////////////////////////
    /////    Cheking to change round        /////
    /////////////////////////////////////////////

    private void NextRound()
    {
        if (CurrentTime >= NextRoundTime)
        {
            CurrentRound += 1;
            CurrentTime = 0;

        }
    }
}
