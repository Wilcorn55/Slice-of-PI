-> main 

=== main ===

Welcome back Detective # name : Michael

I'm assuming you're wanting to know where I was when Aaron was killed?

    +[Yes, tell me where you were and what you know.]
    -> reply ("Well, I'll be honest, it's not going to look good for me.")

=== reply(choice) ===
{choice}

    +[Elaborate please.]
    -> alibi ("I wont be able to provide an alibi or anything, everyone in my house is sound asleep when I go for my walks. That morning when I was out for my walk, I heard some some noises coming from Aarons house but I didn't see anything.")
    
=== alibi(choice) ===
{choice}

    +[Why didn't you go have a look when you heard noises coming from Aarons house?]
    -> final ("I didn't want to get involved in what was happening. Looking back on it now, I wish I did. He might still be alive if I went to have a look. Sorry Detective.")

    +[Are you sure you didn't see anything?]
    -> final ("That's all I know. I'm sorry I couldn't be more help. Good luck Detective")
    
=== final(choice) ===
{choice}


-> END