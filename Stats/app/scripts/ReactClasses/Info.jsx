/** @jsx React.DOM */

var React = require('react'),
    Spec = require('./Spec.jsx'),
    Msdn = require('./Msdn.jsx'),
    Wpd = require('./Wpd.jsx'); 
    

module.exports = React.createClass({
  render: function(){
    var feature = this.props.feature;
    var msdn, wpd;
    if (feature.docs.msdn != undefined && feature.docs.msdn != '') 
      msdn = <Msdn feature={feature}/>;
    if (feature.docs.wpd != undefined && feature.docs.wpd != '') 
      wpd = <Wpd feature={feature}/>;
    
    return(
      <ul className="info">
        <Spec feature={feature} />
        {msdn}
        {wpd}
      </ul>            
    )
  }
});
