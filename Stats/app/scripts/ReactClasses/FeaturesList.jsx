/** @jsx React.DOM */

var React = require('react'),
    Feature = require('./Feature.jsx'); 


module.exports = React.createClass({   
  getInitialState: function () {
    return {arr:[]};
  },  
  componentDidMount: function() {
    $.getJSON("/scripts/PlatformStatus.json", function(json) {
      if (this.isMounted()) this.setState({arr: json.features}); 
      inputInitialize();      
    }.bind(this));
  },
  render: function() {  
    return (
      <div>
        <h3 className="jumbotron search">
          Features:
          <input type="text" className='input' id="input" />
          <select id="select">
            <option>Name</option>
            <option>Class</option>
          </select>
        </h3>
        <ul className='features'>
        {this.state.arr.map(function(feature) {
          return <Feature key={feature.normalized_name} feature={feature}/>
        })}
        </ul>
      </div>
    )
  }    
});

var inputInitialize = function(){
  var input = document.getElementById('input');
  var select = document.getElementById('select');

  $.getScript("/scripts/ui/filter.js", function () {
    input.onkeyup = filter;
    select.onchange = filter;

    if (window.location.hash == "#/") return;
    input.value = window.location.hash.slice(2);
    input.onkeyup();
  })
}
