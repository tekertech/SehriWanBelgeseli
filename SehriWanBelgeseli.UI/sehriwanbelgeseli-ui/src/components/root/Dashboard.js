import React, { Component } from 'react'
import {Container, Row, Col } from 'reactstrap';
import image from '../../image/1.jpg'
import cat  from '../../image/Cat.jpg'
import Navi from "../navi/Navi"
import CategoryList from "../categories/CategoryList";
import ProductList  from "../products/ProductList"


export default class Dashboard extends Component {
    render() {
        return (
            <Container className="themed-container" fluid={true}> 
                   <Row>
                        <Col xs="2"></Col>
                        <Col xs="8">
                           <Navi></Navi>
                        </Col>
                        <Col xs="2"></Col>
                    </Row>
                   <Row>
                        <Col xs="3"></Col> 
                        <Col xs="9" >
                          <img src= {image} alt=""></img> 
                        </Col>
                        <Col xs="3">
                        
                        </Col>
                    </Row> 
                     <Row>
                     <Col xs="2"></Col>
                       <Col xs="3">
                           <CategoryList></CategoryList>
                       </Col>
                       <Col xs="7">
                           <ProductList></ProductList>
                       </Col>
                     </Row>
            </Container>
        )
    }
}
