/** @jsx React.DOM */

var React = require('react');


module.exports = React.createClass({
  render: function(){    
    return(
      <li>
        <a href={this.props.feature.docs.msdn}>
          <span className="icon icon-msdn"></span>
          MSDN
        </a>
      </li>
    )
  }
});
