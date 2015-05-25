/** @jsx React.DOM */

var React = require('react'); 

    
module.exports = React.createClass({    
  render: function(){
    var feature = this.props.feature;
    var iconClassName = "icon icon-" + feature.spec.organization;
    return(
      <li>
        <a href={feature.spec.link}>
           <span className={iconClassName}></span>
           {feature.spec.status}
         </a>
      </li>
    )
  }
});
