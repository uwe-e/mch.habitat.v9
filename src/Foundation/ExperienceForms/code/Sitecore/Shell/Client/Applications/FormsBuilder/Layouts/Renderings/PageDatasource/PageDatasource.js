(function(speak) {
  //speak.component({
  //  name: "PageDatasource",
  //  initialize: function(initial, app, el, sitecore) {
  //  }
  //});
    speak.component(["bclCollection"],
        function (Collection) {
            return speak.extend({},
                Collection.prototype,
                {
                    updateSelectionFromItems: function (option, object) {

                    }
                });
        }, "PageDatasource");
})(Sitecore.Speak);
