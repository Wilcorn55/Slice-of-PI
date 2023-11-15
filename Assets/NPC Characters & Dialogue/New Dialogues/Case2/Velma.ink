->main 

=== main ===

Hi, I'm Velma. #name : Velma

I'm Jonothans girlfriend. You must be the Detective everyone has been talking about.

    +[That's me. Nice to meet you Velma. Is there anything you can tell me about Aarons passing?]
    -> reply ("There isn't much I can tell you really. The only thing I can think of is that Jonothan and Aaron had been bickering back and forth for months whilst campaigning for Mayor.")

=== reply(choice) ===
{choice}

    +[Where were you on the morning of Aarons death?]
    -> alibi ("The morning of Aarons death, I was asleep, I did get woken up when Jonothan got out of bed earlier than usual. He usually gets up to get work done in his office but I'm not sure about that morning since I didn't hear the office door close, I did however hear the backdoor open.")
    
=== alibi(choice) ===
{choice}

    +[Does he normally go outside at that time of morning?]
    -> information ("No, but im sure Jonothan has an explanation for why he left so early. Maybe he went to join Michael on his walks but they haven't been speaking since they both decided to run for Mayor.")
    
=== information(choice) ===
{choice}

    +[Want to add anything else?]
    -> final ("No, I fear I've already said too much. Sorry Detective but I have to go now. Bye.")
    
=== final(choice) ===
{choice}

->END