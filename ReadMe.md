<!--
*** Thanks for checking out the Best-README-Template. If you have a suggestion
*** that would make this better, please fork the repo and create a pull request
*** or simply open an issue with the tag "enhancement".
*** Thanks again! Now go create something AMAZING! :D
***
***
***
*** To avoid retyping too much info. Do a search and replace for the following:
*** github_username, repo_name, twitter_handle, email, project_title, project_description
-->



<!-- PROJECT SHIELDS -->
<!--
*** I'm using markdown "reference style" links for readability.
*** Reference links are enclosed in brackets [ ] instead of parentheses ( ).
*** See the bottom of this document for the declaration of the reference variables
*** for contributors-url, forks-url, etc. This is an optional, concise syntax you may use.
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->
[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]



<!-- PROJECT LOGO -->
<br />
<p align="center">
  <a href="https://github.com/dab2020/JF-secure">
    <img src="images/logo.png" alt="Logo" width="80" height="80">
  </a>

  <h3 align="center">JF-secure</h3>

  <p align="center">
    project_description
    <br />
    <a href="https://github.com/dab2020/JF-secure"><strong>Explore the docs »</strong></a>
    <br />
    <br />
    <a href="https://github.com/dab2020/JF-secure">View Demo</a>
    ·
    <a href="https://github.com/dab2020/JF-secure/issues">Report Bug</a>
    ·
    <a href="https://github.com/dab2020/JF-secure/issues">Request Feature</a>
  </p>
</p>



<!-- TABLE OF CONTENTS -->
<details open="open">
  <summary><h2 style="display: inline-block">Table of Contents</h2></summary>
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
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
    <li><a href="#acknowledgements">Acknowledgements</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project



There are many great reverse-proxy tools available on GitHub, however, I didn't find one that really suit my needs and was easy for users, so I decieded to take open source software like Caddy web-server and NSSM to create a easy tool that will reverse-proxy Jellyfin for you. I want to create a an automated tool that does that for you. Right now its just some files thrown into a installer and some commands loaded into it, but I hope that I can make it into a full tool that is super easy to use.

### Built With

* [Nullisoft sscript insatll system]()
* [NSSM]()
* [Caddy webserver]()



<!-- GETTING STARTED -->
## Getting Started

To get a local copy up and running follow these simple steps.
Clone the repo and open the exe.nsi file in NSIS and compile it. You can experiment by changing the script and .bat files.

### Prerequisites

This is an example of how to list things you need to use the software and how to install them.
* Dynamic Dns or a custom domain
* Port 80 & 443 forwarded to the machine
* Exemption in firewall for port 80 & 443
* remote access allowed in Jellyfin

### Installation

1. Download the latest release combined.zip
2. Extract it
3. Run the JF-secure_install.exe  (keep install location as default)
4. Open the caddyFile and edit the first line to your Jellyfin duckdns or custom domain
5. copy the caddy file to C:\caddy
6. Run the initial.bat file
7. In the pop-up box select select-me-in-NSSM.bat and click OK
8. You are all good to go


<!-- USAGE EXAMPLES -->
## Usage

1. To reverse-proxy Jellyfin
2. To enable remote-access
3. If you change the port in the last line, you can reverse-proxy other services as well



<!-- ROADMAP -->
## Roadmap

See the [open issues](https://github.com/dab2020/JF-secure/issues) for a list of proposed features (and known issues).



<!-- CONTRIBUTING -->
## Contributing

Contributions are what make the open source community such an amazing place to be learn, inspire, and create. Any contributions you make are **greatly appreciated**.

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request



<!-- LICENSE -->
## License

Distributed under the Apache Open Source Licence 2.0 License. See `LICENSE` for more information.



<!-- CONTACT -->
## Contact

Dayyan Abdullah - contact@dayyanabdullah.me

Project Link: [https://github.com/dab2020/JF-secure](https://github.com/dab2020/JF-secure)







<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/github_username/repo.svg?style=for-the-badge
[contributors-url]: https://github.com/github_username/repo/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/github_username/repo.svg?style=for-the-badge
[forks-url]: https://github.com/github_username/repo/network/members
[stars-shield]: https://img.shields.io/github/stars/github_username/repo.svg?style=for-the-badge
[stars-url]: https://github.com/github_username/repo/stargazers
[issues-shield]: https://img.shields.io/github/issues/github_username/repo.svg?style=for-the-badge
[issues-url]: https://github.com/github_username/repo/issues
[license-shield]: https://img.shields.io/github/license/github_username/repo.svg?style=for-the-badge
[license-url]: https://github.com/github_username/repo/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/github_username
