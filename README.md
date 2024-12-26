# PoC .NET - Asterisk

[![wakatime](https://wakatime.com/badge/github/GuilhermeStracini/POC-dotnet-Asterisk.svg)](https://wakatime.com/badge/github/GuilhermeStracini/POC-dotnet-Asterisk)
[![Maintainability](https://api.codeclimate.com/v1/badges/89fc6bf56f31cdbcac71/maintainability)](https://codeclimate.com/github/GuilhermeStracini/POC-dotnet-Asterisk/maintainability)
[![Test Coverage](https://api.codeclimate.com/v1/badges/89fc6bf56f31cdbcac71/test_coverage)](https://codeclimate.com/github/GuilhermeStracini/POC-dotnet-Asterisk/test_coverage)
[![CodeFactor](https://www.codefactor.io/repository/github/GuilhermeStracini/POC-dotnet-Asterisk/badge)](https://www.codefactor.io/repository/github/GuilhermeStracini/POC-dotnet-Asterisk)
[![GitHub license](https://img.shields.io/github/license/GuilhermeStracini/POC-dotnet-Asterisk)](https://github.com/GuilhermeStracini/POC-dotnet-Asterisk)
[![GitHub last commit](https://img.shields.io/github/last-commit/GuilhermeStracini/POC-dotnet-Asterisk)](https://github.com/GuilhermeStracini/POC-dotnet-Asterisk)
[![Build status](https://ci.appveyor.com/api/projects/status/1a2td54xixj4w7k0?svg=true)](https://ci.appveyor.com/project/guibranco/poc-dotnet-asterisk)

🔬 This project is a proof-of-concept (PoC) implementation of integrating Asterisk PABX IP with .NET. It demonstrates how to interact with and utilize Asterisk's functionalities programmatically using the .NET framework.

---

## Getting Started

### Prerequisites

To work with this project, you need the following tools installed:

- **Docker**: For running the Asterisk container. Install from [Docker](https://www.docker.com/).
- **.NET SDK**: Install the latest version from [Microsoft .NET Download](https://dotnet.microsoft.com/download).
- **Git**: For cloning the repository. Download from [Git](https://git-scm.com/).

### Setting Up the Environment

1. Clone the repository:
   ```bash
   git clone https://github.com/GuilhermeStracini/POC-dotnet-Asterisk.git
   cd POC-dotnet-Asterisk
   ```

2. Run the Asterisk Docker container:
   ```bash
   docker run -d --name asterisk \
     -p 5060:5060 \
     -p 5061:5061 \
     -p 8088:8088 \
     -v $(pwd)/asterisk-config:/etc/asterisk \
     mlan/asterisk
3. Restore project dependencies:
   ```bash
   dotnet restore
   ```

4. Build the project:
   ```bash
   dotnet build
   ```

5. Run the application:
   ```bash
   dotnet run
   ```

### Resources

- **Docker Image**: [mlan/asterisk](https://hub.docker.com/r/mlan/asterisk)

## Features

- **Integration with Asterisk PABX**: Demonstrates communication and control of Asterisk through .NET.
- **SIP Protocol Support**: Utilize SIP for managing VoIP calls.
- **REST API Extensions**: Extend Asterisk's capabilities with REST API support.

## Contributing

Contributions are welcome! Feel free to fork the repository, create a new branch, and submit a pull request with your improvements or ideas.

## License

This project is licensed under the MIT License. See the LICENSE file for details.

---

Happy coding! 🎉

