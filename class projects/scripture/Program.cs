// See https://aka.ms/new-console-template for more information

List<string> versus = new List<string>{"16: He saith to him again the second time, Simon, son of Jonas, lovest thou me? He saith unto him, Yea, Lord; thou knowest that I love thee. He saith unto him, Feed my sheep."};
Reference reference = new Reference("John", "21", "16", "16");
Scripture scripture = new Scripture(versus, reference);

Hide memorizer = new Hide(scripture.GetVersus(), reference.GetReference());
