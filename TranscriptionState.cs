using System;

namespace StateKata
{

    public interface ITranscriptionState
    {
        string GetStateDocumentByCode(int stateCode);
    }
    public class TranscriptionState : ITranscriptionState
    {
        public string GetStateDocumentByCode(int stateCode)
        {
            string state = string.Empty;

            switch (stateCode)
            {
                case 1:
                    state = "Draft";
                    break;
                case 2:
                    state = "Review";
                    break;
                case 3:
                    state = "Approve";
                    break;
                case 4:
                    state = "Published";
                    break;
            }

            return state;
        }
    }
}
