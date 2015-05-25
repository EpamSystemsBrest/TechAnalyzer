/** @jsx React.DOM */

var React = require('react');

  
module.exports = React.createClass({
  render: function(){
    return(
      <a href={this.props.feature.browsers[this.props.propName].link}></a>
    )
  }
});
