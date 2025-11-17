<h1>
  <p align="center">  
  <img src="./Images/cat_puter.gif" alt="cat on a PC" width="32" height="32">  
  ── .✦ 9th Wonder Studios Project Page ✦. ── 
  <img src="./Images/cat_puter.gif" alt="cat on a PC" width="32" height="32">
</h1>

[//]: # (Markdown buttons!)
<p align="center"> <img src="https://img.shields.io/badge/unity-%23000000.svg?style=for-the-badge&logo=unity&logoColor=white" alt="Unity">
<img src="https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=csharp&logoColor=white" alt="C#">
<img src="https://img.shields.io/badge/Rider-000000.svg?style=for-the-badge&logo=Rider&logoColor=white&color=black&labelColor=crimson" alt="Rider">
<img src="https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white" alt="Visual Studio">
<br>

<p align="center">
  Welcome to Chandler and Asher's collaboration repository for Computer as a Medium!
</p>
    <br> <br>
    
  <h1>
    <p align="center">
    Week 11 Assignment 
  </h1>
  <h3>
    ── .✦ <i>Chandler's Contributions</i> ✦. ──
  </h3>

<p>
  <img src="./Images/arrow.gif" alt="arrow" width="32" height="20"> 
  <b>GameManager.cs</b> - Implemented a new method, CreateEnemyTwo(), that spawns the enemy 1 prefab either at the top left or top right of the screen. Added a new InvokeRepeating() call to Start() which repeatedly calls the new method at an interval separate from the first.
  <br><br>
  <img src="./Images/arrow.gif" alt="arrow" width="32" height="20"> 
  <b>Enemy.cs</b> - Updated to add a new enemy movement pattern. Based on the position enemy 2 spawns in, it will either move down and left across the screen or down and right across the screen.
</p>
  <br>

  <h3>
    ── .✦ <i>Asher's Contributions</i> ✦. ──
  </h3>

<p>
  <img src="./Images/arrow.gif" alt="arrow" width="32" height="20"> 
  <b>Player.cs</b> - Implemented new code to the player script that uses MathF.Clamp to restrict the player's movement to within the bottom and center of the screen based off of the cameras location
  <br><br>

  <h1>
    <p align="center">
    Week 12 Assignment 
  </h1>
  <h3>
    ── .✦ <i>Chandler's Contributions</i> ✦. ──
  </h3>

<p>
  <img src="./Images/arrow.gif" alt="arrow" width="32" height="20"> 
  <b>GameManager.cs</b> - Implemented a new method, CreateCoin(), which spawns a coin prefab at a random X and Y position on the screen.
  <br><br>
  <img src="./Images/arrow.gif" alt="arrow" width="32" height="20"> 
  <b>Coin.cs</b> - Created this script which is added to every coin prefab that spawns. After 4 seconds have passed, the coin will be destroyed unless the player collides into it. If the player collides into it, it is immediately destroyed and 1 is added to the score by calling GameManager's AddScore() method.
</p>
  <br>
  <h3>
    ── .✦ <i>Asher's Contributions</i> ✦. ──
  </h3>

<p>
  <img src="./Images/arrow.gif" alt="arrow" width="32" height="20"> 
  <b>GameManager.cs</b> - Added code that updates the Score TMP UI with the current score when the score is changed
  <br><br>
</p>
  <br>

<h1>
    <p align="center">
    Week 13 Assignment 
  </h1>
  <h3>
    ── .✦ <i>Chandler's Contributions</i> ✦. ──
  </h3>

<p>
  <img src="./Images/arrow.gif" alt="arrow" width="32" height="20"> 
  <b>PlayerController.cs</b> - Modified the LoseALife() method so that the player does not lose a life if they are hit when the shield power-up is active; the shield is instead deactivated upon collision. The OnTriggerEnter2D() method's switch case for the power-ups was also modified so that if the shield is the randomly chosen power-up it will be activated if it is not already active. If it is already active, nothing happens.
  <br><br>
</p>
  <br>
