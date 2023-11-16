->main

=== main ===

Hello Detective.  #name : Jonothan

Welcome back. How long has it been? 2... 3 years?

    +[Not long enough Jonothan.]
    -> information ("Not the best circumstances for your return. Do you remember our Mayor Aaron? Well a few days ago he was found strangled in his bed. The lock on the back door was found smashed in.")
    
=== information(choice) ===
{choice}

    +[Tell me more.]
    -> electioninformation ("You see, our local election is coming up so I think it may have been one of his political rivals. Darryl, Michael, Aaron and I were all running until his unfortunate passing.")
    
=== electioninformation(choice) ===
{choice}

    +[I'm sorry for your loss.]
    -> suggestion ("Why don't you go around and talk to the towns people like last time? I'm sure they will have more information for you.")
    
=== suggestion(choice) ===
{choice}

    +[Ah yes, I shall do that. Where were you at the time of the murder Jonothan?]
    -> alibi ("Since the coroner said he was killed early in the morning, I would have been at home working in my office. Velma was staying at my place at that time too so she'll be able to confirm that for you.")
    
=== alibi(choice) === 
{choice}

    +[Thank you. See you around Jonothan.]
    -> final ("See ya Detective.")
    
=== final(choice) ===
{choice}


->END