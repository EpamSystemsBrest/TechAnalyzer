/** @jsx React.DOM */

var React = require('react'),
    Link = require('./Link.jsx');

  
module.exports = React.createClass({
  render: function() {
    var feature = this.props.feature;
    var propName = this.props.propName;
    var iconClass = " icon icon-" + propName;
    
    var status;        
    switch(feature.browsers[propName].status) {
      case 'Shipped' :
        status = ' implemented';
        break;
      case 'In Development' :
        status = ' indevelopment'
        break;
      default:
        status = ' ';
    }
    
    var title = feature.browsers[propName].status + ' by ' + propName;
    var browserClass = 'browser' + iconClass + status;
    
    var statusLink;
    if (feature.browsers[propName].link != null){
      statusLink = <Link feature={feature} propName={propName}/>
    }
    
    return (
      <li className={browserClass} title={title}>
        {statusLink}
      </li>
    )  
  }
});
