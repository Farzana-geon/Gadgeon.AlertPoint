const { app, BrowserWindow } = require('electron');
    
    // Executes when the application 
    // is initialized.
    app.on('ready', function() {
        console.log('Starting application!');
        // Create browser window 
        // with given parameters
        mainWindow = new BrowserWindow({ width: 1280, height: 960 });
        mainWindow.loadURL("http://localhost:4200");
    
        // It is useful to open dev tools
        // for debug.
        mainWindow.webContents.openDevTools();
        mainWindow.on('closed', function() {
            mainWindow = null;
        });
    });
    
    // Defines the behavior on close.
    app.on('window-all-closed', function() {
        app.quit();
    });