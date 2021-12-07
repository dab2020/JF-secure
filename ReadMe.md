


<!-- PROJECT LOGO -->
<br />
<p align="center">
  <a href="https://github.com/dab2020/JF-secure">
    <img src="images/logo.png" alt="Logo" width="80" height="80">
  </a>

  <h3 align="center">JF-secure</h3>

  <p align="center">
    A tool stack to automatically reverse proxy Jellyfin
    <br />
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



There are many great reverse-proxy tools available on GitHub, however, I didn't find one that really suit my needs and was easy for users, so I decieded to take open source software like Caddy web-server and NSSM to create a easy tool stack that will reverse-proxy Jellyfin for you. I want to create a an automated stack that does that for you. Right now its just some files thrown into a installer and some commands loaded into it, but I hope that I can make it into a full tool that is super easy to use.

### Built With

* Bat Files
* NSSM
* Caddy webserver
* Python
* NSIS



<!-- GETTING STARTED -->
## Getting Started

To get a local copy up and running follow these simple steps.
Clone the repo and experiment by changing the script and .bat files.

### Prerequisites
* A DDNS or custom domain
* Port 80 & 443 forwarded to the machine
* Exemption in firewall for port 80 & 443
* Remote access allowed in Jellyfin

### Installation
## Note
It was brought to my attention that you may require Visual Studio redistributables, that can be downloaded from <a href="https://docs.microsoft.com/en-us/cpp/windows/latest-supported-vc-redist?view=msvc-170">Microsoft's Offical Site </a>
1. Download the latest release
2. Run the installer
3. Click the shortcut on the desktop
4. Then press a
5. Input the domain as well as the Jellyfin Server address when prompted
6. You are all good to go


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
