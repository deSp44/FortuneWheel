[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]

<!-- PROJECT LOGO -->
<br />
<p align="center">
  <h3 align="center">WordGame</h3>
  <p align="center">
Traditional hangman game in the form of a desktop application. Play with second player and discover all the letters in the guessing sentence, or create a guessable puzzle yourself.
    <br />
    <a href="https://github.com/deSp44/WordGame"><strong>Explore the docs »</strong></a>
	·
    <a href="https://github.com/deSp44/WordGame/issues">Report Bug</a>
	·
    <a href="https://github.com/deSp44/WordGame/issues">Request Feature</a>
  </p>
</p>



<!-- TABLE OF CONTENTS -->
<details open="open">
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#installation">Installation</a></li>
		    <li><a href="#executing-program">Executing program</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <ul>
        <li><a href="#introdution">Introdution</a></li>
		    <li><a href="#preparation-for-the-game">Preparation for the game</a></li>
        <li><a href="#game">Game</a></li>
      </ul>
    <li><a href="#contributing">Contributing</a></li>
	<li><a href="#help">Help</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
  </ol>
</details>

<!-- ABOUT THE PROJECT -->
## About The Project
This project is designed to provide a sentence-guessing game between two users. Users will be able to test their knowledge in various fields and their ability to guess. Additional modifiers may introduce more interesting gameplay.

### Built With
* [Visual Studio 2019](https://visualstudio.microsoft.com/pl/vs/)
* [Windows Forms](https://docs.microsoft.com/pl-pl/dotnet/desktop/winforms/?view=netframeworkdesktop-4.8)
* [C# 9.0](https://docs.microsoft.com/pl-pl/dotnet/csharp/whats-new/csharp-9)
* [.NET Framework 4.8](https://dotnet.microsoft.com/download/dotnet-framework/net48)

<!-- GETTING STARTED -->
## Getting Started

To get a local copy up and running follow these simple steps.

### Installation
Clone the repo from git
   ```sh
   git clone https://github.com/deSp44/WordGame.git
   ```
   or
   
In Visual Studio, just paste the link in the "Clone a repository" section
   ```sh
   https://github.com/deSp44/WordGame.git
   ```
   
### Executing program
Just build solution using the Ctrl + Shift + B shortcut or by right-clicking the solution and the "Build Solution" option. After that the .exe file will be waiting for you in the bin folder.

<!-- USAGE EXAMPLES -->
## Usage

### Introdution
After starting the program, the user is presented with the main menu.
<p align="center">
  <img src="https://user-images.githubusercontent.com/56117577/126140557-e0489071-57d6-423f-a4a6-33d61f731936.png" />
</p>
Select the game mode you want to run.

### Preparation for the game
In hangman mode, the user enters a word to guess, which will later be scrambled for the other player. It can be one word or a sentence. Category should also be selected. This can be done by selecting the default category via the dropdown menu, but the user can also enter their category.

Additional optional options in the game are the setting of the maximum number of incorrect hits and the time limit.

<p align="center">
  <img src="https://user-images.githubusercontent.com/56117577/126141898-146f30f6-5297-46c9-b3f5-aa4f589fa612.png" />
</p>

### Game
The game begins.

Letters that have not been guessed so far are encrypted in the form of asterisks. If additional difficulties have been selected in the form of the number of bad hits or a time limit, these statistics will be visible in the upper right corner of the application.
<p align="center">
  <img src="https://user-images.githubusercontent.com/56117577/126142042-ec2a3001-94c8-4a27-9ebf-6d30e96c47e3.png" />
</p>

The letters are selected from the buttons available on the panel. If we hit, the button will turn green, if not, the button will be red.
<p align="center">
  <img src="https://user-images.githubusercontent.com/56117577/126142761-a411e2ce-cbcf-4db5-a96f-e94d3b68c038.png" />
</p>

After the game is over, we will get its result and statistics in the window on the right. We can exit the game or create a new guessing sentence.
<p align="center">
  <img src="https://user-images.githubusercontent.com/56117577/126143149-dbae1d1e-9e38-4ad9-a9e2-66b38f6ffd5a.png" />
</p>


<!-- CONTRIBUTING -->
## Contributing
Contributions are what make the open source community such an amazing place to be learn, inspire, and create. Any contributions you make are **greatly appreciated**.

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

<!-- HELP -->
## Help
At the moment, the "Help" section is empty. Frequently asked questions will be added in case of problems.

<!-- LICENSE -->
## License
Distributed under the MIT License. See `LICENSE` for more information.

<!-- CONTACT -->
## Contact
Michał Czaja
<br />
LinkedIn : [Michał Czaja](https://pl.linkedin.com/in/micha%C5%82-czaja-735013209)
<br />
Twitter : [@deSp_97](https://twitter.com/deSp_97)
<br />
Stack Overflow : [deSp](https://stackoverflow.com/users/15499426/desp)
<br />
Project Link: [https://github.com/deSp44/WordGame](https://github.com/deSp44/WordGame)



<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/deSp44/WordGame.svg?style=for-the-badge
[contributors-url]: https://github.com/deSp44/WordGame/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/deSp44/WordGame.svg?style=for-the-badge
[forks-url]: https://github.com/deSp44/WordGame/network/members
[stars-shield]: https://img.shields.io/github/stars/deSp44/WordGame.svg?style=for-the-badge
[stars-url]: https://github.com/deSp44/WordGame/stargazers
[issues-shield]: https://img.shields.io/github/issues/deSp44/WordGame.svg?style=for-the-badge
[issues-url]: https://github.com/deSp44/WordGame/issues
[license-shield]: https://img.shields.io/github/license/deSp44/WordGame.svg?style=for-the-badge
[license-url]: https://github.com/deSp44/WordGame/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://www.linkedin.com/in/micha%C5%82-czaja-735013209/
