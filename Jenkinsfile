pipeline {
    agent any
    
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
                sh 'dotnetRestore'
                
                // Build the project
                sh 'dotnetBuild'
            }
        }
        
        stage('Test') {
            steps {
                // Run tests
                sh 'dotnetTest'
            }
        }
        
        stage('Publish') {
            steps {
                // Publish the project
                sh 'dotnetPublish -c Release -o ./publish_output'
            }
        }
    }
}
