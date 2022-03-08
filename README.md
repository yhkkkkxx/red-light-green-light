# red-light-green-light
mugunghwa🌺 game with some missions added

+ *with Unity, C#*   
+ *inspired by SQUID GAME*
+ *completed this project on December 20th, 2021*
+ *written in English for **ganzi***

🔴🦑👧🟢

---

### 📌 original game rule
```
- tagger says '무궁화 꽃이 피었습니다(GREEN LIGHT)' showing its back
- you can move only when tagger doesn't look at you
- if you cross RED LINE in front of the tagger, you win
```

### 📌 added rule
```
- before you reach RED LINE, there are lots of obstacles that interrupt your course
- you have to eat all DALGONA, if you don't, you can't pass through the RED LINE
- there is timer that measure your playing time
```
---

### 1️⃣ start scene - title and three buttons
<img width="50%" height="50%" src="https://user-images.githubusercontent.com/90179774/157258373-d4076683-f06c-4697-b00a-53c1bb51cf30.PNG"/>

#### ✔ click **play** button  
+ go to 2️⃣

#### ✔ click **how to play** button  
<img width="50%" height="50%" src="https://user-images.githubusercontent.com/90179774/157259234-0421915d-6e6e-4c9a-a476-1a341471efc5.PNG"/>  

+ **HowToPlay Panel** is active
+ you can see game rule *in Korean*
+ **Back Button** inactive this panel

#### ✔ click **settings** button  
<img width="50%" height="50%" src="https://user-images.githubusercontent.com/90179774/157261299-dbd2858a-5e8c-4f8e-a217-6a3e4064c1b0.PNG"/>

+ **Settings Panel** is active
+ you can control sfx sound and background music volume
+ **Back Button** inactive this panel

### 2️⃣ game scene
<img width="50%" height="50%" src="https://user-images.githubusercontent.com/90179774/157271440-15af93f7-047d-4571-a094-50e5c2f991cb.gif"/>

+ timer is on
+ you can move player with direction key


#### ✔ click **pause(||)** button  
<img width="50%" height="50%" src="https://user-images.githubusercontent.com/90179774/157272612-787c3120-f8f6-4cbf-a49d-b5c6d962ac38.gif"/>

+ **Resume Button** can resume game

<img width="50%" height="50%" src="https://user-images.githubusercontent.com/90179774/157273190-3a115194-6380-4d72-8e92-98f62a27e8c8.gif"/>

+ **Restart Button** can restart game
+ timer and player's position is reset to initial state

<img width="50%" height="50%" src="https://user-images.githubusercontent.com/90179774/157273199-90cc21dd-4e2e-4289-89f5-877b0b83f61e.gif"/>

+ **Back To Title Button** let go back to the **Start Scene**


#### ✔ if you reach **RED LINE**  
<img width="50%" height="50%" src="https://user-images.githubusercontent.com/90179774/157277202-feeaeec6-9c0f-444b-89bc-9ed8092a8f2b.gif"/>

+ **Success Panel** is active
+ your time record will be shown
+ you can restart game, go back to title

##### 🚨 if you don't eat all DALGONA, you can't cross the RED LINE🚨
<img width="50%" height="50%" src="https://user-images.githubusercontent.com/90179774/157277218-a5db4bfd-b122-4f7f-bf66-59f3468e5f5b.gif"/>


#### ✔ if you die  
<img width="50%" height="50%" src="https://user-images.githubusercontent.com/90179774/157277212-a4c50914-cc38-4094-b63d-ff6003e48084.gif"/>

+ **Die Panel** is active
+ you can restart game, go back to title

---

ℹ **I used all extracted sounds from SQUID GAME**  

ℹ **I used Assets  
*player - Character Pack: Free Sample(Supercyan)  
tagger - NPC Character - Proto Series(BitGem)  
obstacles - Dungeon Traps(Torulo)   
plane pattern - World Materials Free(Avionx)*  
from Asset Store**
