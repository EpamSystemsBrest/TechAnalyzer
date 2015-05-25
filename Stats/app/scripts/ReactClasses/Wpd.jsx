/** @jsx React.DOM */

var React = require('react');


module.exports = React.createClass({
  render: function(){    
    return(
      <li>
        <a href={this.props.feature.docs.wpd}>
          <span className="icon icon-webplatform"></span>
          WebPlatform
        </a>
      </li>
    )
  }
});
