module.exports = {
    testEnvironment: 'jsdom',
    roots: ['<rootDir>/src'],
    testMatch: ['**/__tests__/**/*.js', '**/?(*.)+(spec|test).js'],
    setupFilesAfterEnv: ['<rootDir>/src/setupTests.js'],
};