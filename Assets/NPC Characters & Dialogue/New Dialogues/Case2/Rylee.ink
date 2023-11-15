-> main

=== main ===

Hi Sir, #name : Rylee

How are you doing?

    +[Very well thank you]
    -> feeling ("good to hear.")
    
    +[Doing alright at the moment]
    -> feeling ("hope it gets better for you.")
    
=== feeling(choice) ===
Oh, {choice} I'm Rylee, Michael is my grandad.

    +[Nice to meet you Rylee]
    -> question ("Are you going to arrest someone for the murder?")
    
=== question(choice) ===
{choice}
    
    +[That's the goal, do you know anything about the murder?]
    -> information ("You know it wasn't my grandad right? He was alseep all night until he wen for his walk. I know this because I like to sneak downstairs at night and play games. But I havee to quickly turn them off when he goes for his walks.")
    
=== information(choice) ===
{choice}

    +[Thank you Rylee, I wont tell Michael about you gaming all night. Your secret is safe with me.]
    -> final ("Thank you kind detective!")

=== final(choice) ===
{choice}


->END