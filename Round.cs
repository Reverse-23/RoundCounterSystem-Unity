public class Roudns : MonoBehaviour
{
    // Vaiables
    //Audio source it's if you want to play audio while round transiction

    public Text Roundtxt;
    //public AudioSource audioSource;
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
            
            //if (CurrentRound >= 2)
            //{
            //    audioSource.Play();
           // }


        }
    }
}
