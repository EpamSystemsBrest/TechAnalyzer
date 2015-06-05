var React = window.React = require('react'),    
    mountNode = document.getElementById("app"),
    FeaturesList = require('./ReactClasses/FeaturesList.jsx');


var FeaturesApp = React.createClass({
  render: function () {
    return ( 
      <div className ='stats'>
        <FeaturesList />
      </div>   
    )
  }
});

React.render(<FeaturesApp />, mountNode); 
