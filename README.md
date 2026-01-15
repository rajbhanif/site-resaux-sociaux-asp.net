# Frendify – Réseau Social ASP.NET Core

Une application web de réseau social moderne et complète, développée avec **ASP.NET Core MVC** et **Entity Framework Core**. Cette plateforme permet aux utilisateurs de se connecter, de partager des moments et d'interagir en temps réel.

## Aperçu du Projet

Frendify est une plateforme sociale qui recrée les fonctionnalités essentielles d'un réseau moderne. Les utilisateurs peuvent publier des posts et des stories, gérer un cercle d'amis et interagir via un système de likes et de favoris. L'interface responsive, conçue avec Tailwind CSS, et les mises à jour en temps réel via SignalR offrent une expérience utilisateur fluide et engageante.

## Fonctionnalités

### Gestion du Contenu Social
*   **Publications et Stories** : Créez, modifiez et partagez des posts et des stories éphémères.
*   **Interactions Sociales** : Système complet de likes, de favoris et de partages.
*   **Gestion des Relations** : Envoyez, acceptez, refusez ou annulez des demandes d'amis avec une interface intuitive.
*   **Tendances en Direct** : Découvrez les sujets populaires grâce à une section dédiée aux hashtags les plus utilisés.
*   **Temps Réel** : Recevez des notifications et voyez les interactions se produire instantanément grâce à l'intégration de **SignalR**.

### Caractéristiques Techniques
*   **Architecture Robust** : Application structurée selon le pattern **MVC (Model-View-Controller)** pour une séparation claire des responsabilités et une maintenabilité optimale.
*   **Gestion des Données** : **Entity Framework Core** est utilisé pour le mapping objet-relationnel (ORM), gérant les migrations et les interactions avec la base de données **SQL Server**.
*   **Interface Moderne** : Frontend élégant et entièrement responsive construit avec **Tailwind CSS**, **HTML**, **CSS** et **JavaScript**.
*   **Performance Optimisée** : Le backend en **C#** et **ASP.NET Core** assure des temps de réponse rapides et une gestion efficace des requêtes.

## Comment Utiliser / Démarrage

### Processus d'Utilisation (Pour les Utilisateurs Finaux) :
1.  **Inscription & Connexion** : Créez un compte ou connectez-vous.
2.  **Personnalisation** : Complétez votre profil.
3.  **Connexions** : Recherchez et envoyez des demandes d'amis.
4.  **Partage** : Publiez des posts (texte, images) avec des hashtags.
5.  **Interaction** : Likez, commentez et enregistrez en favori les publications de vos amis.
6.  **Découverte** : Consultez la section "Tendances" et les stories de vos contacts.
7.  **Temps Réel** : Recevez des notifications instantanées lorsqu'un ami interagit avec votre contenu.

## Défis Techniques et Solutions

Ce projet a permis de relever plusieurs défis intéressants :
*   **Gestion des relations utilisateurs** : Conception d'un modèle de données efficace pour gérer les états complexes des demandes d'amis (en attente, acceptée, refusée).
*   **Intégration de SignalR** : Mise en place d'une communication bidirectionnelle en temps réel pour les notifications et les mises à jour de flux.
*   **Architecture scalable** : Organisation du code en couches distinctes (Modèles, Vues, Contrôleurs, Services) pour faciliter les évolutions futures.
*   **Expérience utilisateur front-end** : Utilisation de Tailwind CSS pour créer une interface cohérente et réactive sans surcharge de CSS personnalisé.

## Technologies Utilisées (Stack)

*   **Backend** : C#, ASP.NET Core MVC, Entity Framework Core, SignalR
*   **Frontend** : Tailwind CSS, HTML, CSS, JavaScript
*   **Base de Données** : SQL Server
*   **Gestion de Version** : Git

## Autrice
**Raj Beghum Hanif**
Projet académique - Développement d'applications Web avec ASP.NET Core.
