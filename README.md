# dotnet-api

dotnet api conteinerized with docker and with ci/cd

# TDD Approach

# Running the image:
- docker run -p 8080:80 --name users-api dockerapi
# Roadmap
- Install postgres database using docker
- Make an api image from docker
- Make a pipeline for building and testing the application

# Docker images:
## Postgres
- User: postgres
- Password: postgres


### TODO-LIST:
- [ ] Change Users.Common to a classlib
- [ ] Create a nuget package from the class lib
- [ ] Add redis on the program (using docker)
- [ ] Add rabbitmq on the program (using docker)
- [ ] Add postgres on the program (using docker)