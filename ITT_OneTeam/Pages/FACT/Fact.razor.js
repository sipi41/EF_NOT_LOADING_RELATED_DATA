
export var FactFunctions = {

    Initialization: async () => {

        
    },

    HideOffCanvasMenu: async () => {

        const SideMenu = await bootstrap.Offcanvas.getOrCreateInstance("#SideMenu");

        await SideMenu.hide();

    },

    ShowOffCanvasMenu: async () => {

        const SideMenu = await bootstrap.Offcanvas.getOrCreateInstance("#SideMenu");

        await SideMenu.show();

    },

}