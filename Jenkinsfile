pipeline {
    agent any

    environment {  
        dotnet = 'C:\\Program Files\\dotnet\\dotnet.exe'  
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
                bat 'dotnet restore'
                
                // Build the project
                bat 'dotnet build'
            }
        }
        
        stage('Test') {
            steps {
                // Run tests
                bat 'dotnet test'
            }
        }
        
        stage('Publish') {
            steps {
                // Publish the project
                bat 'dotnet publish -c Release -o ./publish_output'
            }
        }
    }
}
