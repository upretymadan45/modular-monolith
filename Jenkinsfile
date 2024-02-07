pipeline {
    agent {
        docker {
            image 'mcr.microsoft.com/dotnet/sdk:8.0'
            // Run the Docker container in privileged mode
            args '-u root:root --privileged'
        }
    }

    stages {
        stage('Checkout') {
            steps {
                // Checkout source code from repository
                git credentialsId: 'github_access_token', url: 'https://github.com/upretymadan45/modular-monolith.git'
            }
        }
        
        stage('Build') {
            steps {
                // Restore dependencies
                sh 'dotnet restore'
                
                // Build the project
                sh 'dotnet build'
            }
        }
        
        stage('Test') {
            steps {
                // Run tests
                sh 'dotnet test'
            }
        }
        
        stage('Publish') {
            steps {
                // Publish the project
                sh 'dotnet publish -c Release -o ./publish_output'
            }
        }
    }
}
