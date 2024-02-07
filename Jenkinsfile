pipeline {
    agent any
    
    stages {
        stage('Checkout') {
            steps {
                // Checkout source code from repository
                git credentialsId: 'github_access_token', url: 'https://github.com/upretymadan45/modular-monolith.git'
            }
        }
        
        stage('Run Docker Commands') {
            steps {
                script {
                    // Start a Docker container using a .NET SDK image
                    def dockerImage = 'mcr.microsoft.com/dotnet/sdk:5.0'
                    docker.image(dockerImage).inside('-u root:root --privileged') {
                        // Execute Docker commands inside the container
                        sh 'dotnet restore'
                        sh 'dotnet build'
                        sh 'dotnet test'
                        sh 'dotnet publish -c Release -o ./publish'
                    }
                }
            }
        }
    }
}
