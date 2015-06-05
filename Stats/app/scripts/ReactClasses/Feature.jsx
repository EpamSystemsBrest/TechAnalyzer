/** @jsx React.DOM */

var React = require('react'),
    Info = require('./Info.jsx'),
    Browsers = require('./Browsers.jsx'); 


module.exports = React.createClass({
  render: function(){  
    var feature = this.props.feature;
      
    var browsersArr = [];
    for(browser in feature.browsers)
      browsersArr.push(browser);
    
    var categoryClass="icon icon-"+feature.normalized_category;
    
    return (
      <li className='feature jumbotron'>
        <h4 title={feature.category}>
          <span className={categoryClass}></span>
          {feature.name}
        </h4>
        <p>{feature.summary}</p>  
        <div className="urls">
          <Info feature={feature}/>
          <ul className='browsers'>
            {browsersArr.map(function(propName){
              return <Browsers key={propName} 
                feature = {feature}
                propName = {propName}
              />
            })}
          </ul>        
        </div>
      </li>          
    )
  }
});
