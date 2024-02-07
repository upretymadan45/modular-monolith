pipeline {
    agent any
    environment {
        PATH = "$PATH:/usr/local/share/dotnet"
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
               sh 'dotnet build'
            }
        }
    }
}
