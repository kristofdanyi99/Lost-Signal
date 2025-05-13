# Mobile Game Requirements and Specifications Document

## 1. Executive Summary
**Game Title:** Lost Signal
**Development Studio:** [Your Studio Name]
**Target Platforms:** iOS and Android via Unity
**Business Model:** Free-to-play with ads monetization
**Genre:** Puzzle (logic-based, casual)
**Target Release Date:** [Estimated Date]

**Project Objectives:**
- Develop an engaging mobile game for iOS and Android platforms
- Implement effective ad-based monetization strategies
- Learn and optimize app monetization techniques
- Create a visually appealing, intuitive puzzle experience
- Build a scalable level progression system

**Overview:** Lost Signal is a fast-paced mobile puzzle game where players reconnect broken communication lines by fixing circuit puzzles. Designed for casual players, it blends drag-to-connect gameplay with evolving mechanics and adorable visual storytelling - all wrapped in short, satisfying levels.


---

## 2. Game Overview

### 2.1 Game Concept
Lost Signal is a logic-based puzzle game where players restore broken communication networks by connecting the right nodes with wires. Set in a stylized digital world, players must create clean, efficient pathways to transmit signals across increasingly complex circuit boards. Each level presents a unique configuration of nodes that must be connected without overlaps or errors. As players progress, new mechanics are introduced, including switches, broken nodes, and special connection types that add depth to the gameplay while maintaining the accessible core mechanic of drawing connections between points.

### 2.2 Core Game Loop
1. Players examine the level layout to identify required connections
2. Tap on a node to begin a wire connection
3. Drag the wire to the target node and release to complete connection
4. Continue connecting nodes until all required connections are made
5. Complete the level when all connections are correctly established
6. Earn Pulses (currency) based on performance and advance to next level
7. Periodically encounter new mechanics that add complexity to the puzzle-solving

### 2.3 Target Audience
- **Primary Demographic:**  
<u>Casual Mobile Gamers</u>  
Age range: 12+  
Interests: Puzzle games, solving logical problems  
Gaming Habits: Frequent in short - medium durations. Play mobile games whilst commuting

- **Secondary Demographic:**  
Logic puzzle enthusiasts  
Age range: 18-45  
Interests: Brain teasers, strategy games, pattern recognition  
Gaming Habits: Dedicated gaming sessions, appreciation for progressively challenging content

- **Regional Focus:** Local (UK) initial focus with global scalability

### 2.4 Unique Selling Points
- Unique wire-connection mechanic with familiar puzzle concept
- Puzzling but not brain straining, perfect for commutes and short breaks
- Progressive difficulty curve that improves logical reasoning skills
- Visually satisfying feedback when completing circuits
- Quick play sessions (30 seconds to 3 minutes per level)

### 2.5 Competitive Analysis
| Competitor | Key Features | Monetization Approach | Strengths | Weaknesses |
|------------|--------------|----------------------|-----------|------------|
| Infinity Loop | Minimalist connection puzzles | Free with ads, premium version | Clean UI, satisfying connections | Limited progression mechanics |
| Flow Free | Connect colored dots | Ad-supported with IAP | Simple concept, huge level library | Dated visuals, predictable gameplay |
| Transmission | Signal routing puzzles | Premium with no ads | Polished mechanics, unique theme | Higher entry barrier, smaller audience |

---

## 3. Technical Specifications

### 3.1 Development Platform
- **Engine:** Unity 2022.3 LTS 
- **Programming Language:** C#
- **Version Control:** GitHub

### 3.2 Target Device Specifications

#### iOS Requirements:
- **Minimum iOS Version:** iOS 13.0+
- **Target Devices:** iPhone 8 and newer
- **Minimum RAM:** 2GB
- **Storage Required:** Approximately 200 MB (Max with fully developed product)

#### Android Requirements:
- **Minimum Android Version:** Android 7.0 (API level 24)
- **Target Devices:** Mid-range and higher Android phones from 2019 onward
- **Minimum RAM:** 3GB
- **Storage Required:** Approximately 200 MB (Max with fully developed product)
- **Processor:** Snapdragon 660 equivalent or better

### 3.3 Technical Features
- **Rendering Pipeline:** Universal Render Pipeline (URP)
- **Screen Orientation:** Portrait
- **Frame Rate Target:** 60 FPS (30 FPS minimum)
- **Resolution Support:** Multiple aspect ratios (16:9, 18:9, 19:9, etc.)
- **Online Requirements:** Available for both online and offline
- **Cloud Saves:** No - local save data only

### 3.4 Third-Party SDKs and Services
- Unity Ads
- Google AdMob
- ironSource/AppLovin MAX for ad mediation
- Unity IAP
- Firebase Analytics
- Firebase Crashlytics
- Firebase Remote Config (for level balancing)

---

## 4. Gameplay Specifications

### 4.1 Game Mechanics
- **Core Connection Mechanic:**
  - Tap a node to begin a wire connection
  - Drag to another node to create a connection
  - Connections must be made without overlapping wires
  - All required nodes must be connected to complete a level

- **Special Mechanics:**
  - **Wire Types:** Standard wires connect any two compatible nodes, special wires have specific requirements
  - **Node Types:**
    - Standard: Basic connection point
    - Sender: Origin point that must connect to a Receiver
    - Receiver: Destination point that must receive connection from a Sender
    - Multi-connection: Can accept multiple wire connections
    - Limited connection: Can only accept specific number of connections
    - Broken: Cannot be used for connections, obstacles to work around

- **Progression Mechanics:**
  - **Level 1-10:** Introduction to basic connections
  - **Level 11-25:** Introduction to multi-connections and limited nodes
  - **Level 26-50:** Introduction to broken nodes and obstacles
  - **Level 51+:** Complex combinations of all mechanics

- **Fail Conditions:**
  - Connecting to incorrect nodes
  - Creating overlapping connections
  - Failing to connect all required nodes

### 4.2 Controls and User Interface
- **Control Scheme:** 
  - Tap to target node
  - Swipe whilst holding to drag wire
  - Release at target node to complete connection
  - Double-tap a connection to remove it

- **UI Elements:**
  - **Game Screen:**
    - Circuit board with nodes
    - Level progress indicator
    - Move counter
    - Pulse counter (currency)
    - Menu button
    - Hint button (watch ad for hint)
    - Retry button

  - **Main Menu:**
    - Level Select grid
    - Themes gallery
    - Store button
    - Settings button
    - Daily reward claim

  - **Store:**
    - Permanent ad removal option
    - Theme packs
    - Hint packages
    - Limited-time offers

  - **Settings:**
    - Vibration toggle
    - Sound effects toggle
    - Music toggle
    - Notifications toggle
    - Privacy policy link
    - Credits

- **Accessibility Features:** 
  - Colorblind theme option
  - Haptic feedback for successful/unsuccessful connections
  - Text size options

### 4.3 Progression System
- **Level Structure:** Linear level progression with branching challenge levels
- **Difficulty Curve:** 
  - Gradually introduces new mechanics every 10-15 levels
  - Progressive increase in complexity of node arrangements
  - Tutorial levels for each new mechanic
  - Occasional "breather" levels after particularly challenging ones

- **Player Progression:** 
  - Level completion unlocks subsequent levels
  - Earning Pulses unlocks cosmetic content and themes
  - Performance rating (1-3 stars) based on efficiency and speed
  - Achievement system linked to gameplay milestones

- **Unlockable Content:** 
  - Visual themes (changes the look of circuit boards and nodes)
  - Special effects for successful connections
  - Node skins

### 4.4 Game Economy
- **Currency Types:** Pulses (soft currency)
- **Currency Sources:** 
  - Level completion rewards (10-25 Pulses)
  - Perfect solutions bonus (additional 5-15 Pulses)
  - Daily login rewards (scaling from 5-50 Pulses)
  - Watching rewarded ads (20 Pulses per ad)

- **Currency Sinks:** 
  - Purchasing themes (150-500 Pulses)
  - Unlocking hint packages (100 Pulses for 5 hints)
  - Special node skins (75-300 Pulses)

- **Economy Balance:** 
  - Standard level completion path provides enough currency for basic unlocks
  - Perfect solutions and ad viewing required for premium cosmetics
  - Approximately 7-10 days of regular play to unlock first major theme

---

## 5. Art and Audio Direction

### 5.1 Visual Style
- **Art Style:** Stylized, cartoony tech aesthetic with clean lines and vibrant accents
- **Theme Concept:** "Digital Transmission" - A world of circuit boards and electronic components with personified signal elements

- **Color Palette:**
  - **Primary Background:** Deep Navy Blue (#1A2238)
  - **Node Colors:**
    - Active Nodes: Vibrant Cyan (#38E1F2)
    - Target Nodes: Warm Amber (#F0A202)
    - Broken/Dummy Nodes: Muted Gray (#9DA2AB)
  - **Wire Colors:**
    - Default Wire: Electric Blue (#4FC0D0)
    - Correct Connection: Glowing Green (#21D375)
    - Error Connection: Bright Pink (#FF3366)
  - **UI Elements:**
    - Menu Background: Dark Slate (#2D3047)
    - Button Highlights: Bright Cyan (#38E1F2)
    - Text: White (#FFFFFF) and Light Gray (#E6E8E6)
    - Success Elements: Mint Green (#21D375)
  - **Accent Colors:**
    - Progress Elements: Purple (#9067C6)
    - Premium Features: Gold (#F9C80E)
    - "Pulses" Currency: Pulsing Light Blue (#7AD7F0) with white glow effects

- **Reference Images:** [Include links or attachments to visual references]

### 5.2 Character/Object Design
- **Nodes:**
  - Simple circular base with glowing inner elements
  - Dynamic pulse animations when interacted with
  - Clear visual distinction between node types using both color and iconography
  - Subtle idle animations (gentle pulsing/rotating elements)

- **Wires:**
  - Clean, slightly rounded connections with glow effects
  - Visual "energy" that flows through connected wires
  - Connection animation that shows signal traveling from source to target

- **Background Elements:**
  - Subtle circuit patterns that don't interfere with gameplay
  - Ambient movement of tiny "data packets" in the background
  - Low-opacity grid lines to help with spatial awareness

### 5.3 UI Design
- **UI Style:** Clean, minimal tech interface with rounded corners and subtle glow effects
- **UI Color Scheme:** Dark backgrounds with bright, contrasting elements for clear visibility
- **Font Choices:** 
  - Primary: Modern sans-serif font with slight tech styling (like "Exo 2" or "Rajdhani")
  - Secondary: Clean, highly readable sans-serif for instructions (like "Open Sans")

### 5.4 Alternative Themes (Unlockable)
1. **Retro Tech:** Green-on-black terminal style with pixelated elements
   - Background: Black (#0D0D0D)
   - Elements: Phosphor Green (#33FF33)
   - Accents: Amber (#FFB000)

2. **Neon Nights:** Cyberpunk-inspired with vibrant neons against dark backgrounds
   - Background: Deep Purple-Black (#1A0B2E)
   - Elements: Neon Pink (#FF00FF), Electric Blue (#00FFFF)
   - Accents: Neon Yellow (#FFFF00)

3. **Colorblind-Friendly:** High contrast with patterns to differentiate elements
   - Background: Light Gray (#E5E5E5)
   - Elements: Black (#000000), Blue (#0000FF), Orange (#FF7900)
   - Elements use both color and pattern differentiation

### 5.5 Audio Design
- **Music Style:** Ambient electronic with subtle rhythmic elements
- **Sound Effects:**
  - Node selection: Soft click with electronic tone
  - Successful connection: Satisfying "connection" sound with rising tone
  - Failed connection: Short error tone (not annoying or harsh)
  - Level completion: Triumphant electronic jingle
  - Menu navigation: Subtle UI sounds

- **Audio Implementation:**
  - Adaptive music system that responds to player progress within a level
  - Layered sound effects for complex interactions
  - Audio mixing to ensure sounds remain balanced on mobile devices
  - All audio elements designed to sound good on mobile speakers

---

## 6. Monetization Strategy

### 6.1 Revenue Model Overview
- Primary model: Free-to-play with advertising
- Secondary revenue streams: Optional IAPs for cosmetics and ad removal
- Projected ARPDAU (Average Revenue Per Daily Active User): $0.03-0.05

### 6.2 Ad Implementation
- **Ad Formats:**
  - Interstitial ads: Every 3 completed levels
  - Rewarded video ads: 
    - Optional hints (watch ad for solution assistance)
    - Currency boosts (watch ad for bonus Pulses)
    - Continue play (watch ad to retry failed level without penalty)
  - Banner ads: Small banner at bottom of level select screen only (not during gameplay)

- **Ad Network Integration:**
  - Primary network: Unity Ads
  - Secondary networks: AdMob
  - Mediation platform: AppLovin MAX

- **Ad Frequency Caps:**
  - Maximum ads per session: 5 interstitials
  - Minimum time between interstitials: 60 seconds
  - Cool-down periods: No ads for first 3 minutes of first session of the day

### 6.3 In-App Purchases (Optional)
- **IAP Categories:**
  - "Signal Boost" (Remove Ads): $2.99
  - "Pulse Packs": 
    - Small: 500 Pulses for $0.99
    - Medium: 1500 Pulses for $2.49
    - Large: 5000 Pulses for $4.99
  - "Theme Collections": 
    - Retro Pack: $1.99
    - Neon Pack: $1.99
    - Complete Bundle: $4.99

- **IAP Strategy:**
  - Ad removal provides substantial quality-of-life improvement
  - Currency packs offer 30-50% better value than earning through gameplay
  - Special theme bundles include exclusive visual effects not available for soft currency

### 6.4 Player Retention Features
- Daily rewards system (increasing value for consecutive days)
- Daily challenges with bonus currency rewards
- Limited-time special themes tied to seasons/holidays
- Achievement system with currency rewards
- Push notification strategy for lapsed players (respectful, not spammy)

### 6.5 Monetization KPIs
- Ad impression targets: 4-5 per DAU
- Click-through rate goals: >2% for rewarded, >0.5% for interstitials
- Retention targets: D1: 40%, D7: 20%, D30: 8%
- Session length goals: 5-8 minutes average
- IAP conversion rate goal: 2-3% of players make at least one purchase

---

## 7. User Acquisition and Analytics

### 7.1 Analytics Implementation
- **Key Events to Track:**
  - Level starts, completions, and failures
  - Time spent per level
  - Node connection patterns (heatmaps)
  - Ad views, completions, and clicks
  - Currency earned and spent
  - Feature usage (hints, retries, etc.)
  - Theme preferences

- **Analytics Platforms:**
  - Primary: Firebase Analytics
  - Secondary: GameAnalytics

### 7.2 Key Performance Indicators
- **Engagement Metrics:**
  - DAU/MAU (Daily/Monthly Active Users)
  - Average session length
  - Sessions per day per user
  - Retention rates (D1, D7, D30)
  - Level completion rates

- **Monetization Metrics:**
  - ARPDAU (Average Revenue Per Daily Active User)
  - Ad eCPM (effective Cost Per Mille)
  - Ad fill rate
  - LTV (Lifetime Value)
  - ROAS (Return On Ad Spend) for UA campaigns

### 7.3 User Acquisition Strategy
- **Organic Acquisition:**
  - App Store Optimization (ASO) with puzzle-focused keywords
  - Content marketing on puzzle game communities
  - Social media presence focusing on satisfying puzzle solutions

- **Paid Acquisition:**
  - Primary UA channels: Facebook Ads, Google UAC
  - CPI (Cost Per Install) targets: £0.30-0.50
  - Initial UA budget allocation: 70% testing, 30% scaling

### 7.4 A/B Testing Framework
- **Test Categories:**
  - Ad placement and frequency
  - Level difficulty balancing
  - First-time user experience
  - Currency reward amounts
  - Visual theme preferences

- **Testing Methodology:**
  - Test group size: Minimum 1,000 users per variant
  - Minimum test duration: 7 days
  - Success criteria: Retention and ARPDAU improvements

---

## 8. Development Roadmap

### 8.1 Development Phases
- **Pre-production:** [Dates]
  - Game design document finalization
  - Art style prototyping
  - Core mechanics implementation
- **Production:** [Dates]
  - Level creation system development
  - First 50 levels creation
  - UI implementation
  - Monetization integration
- **Testing:** [Dates]
  - Internal playtesting
  - Balancing adjustments
  - Ad integration testing
  - Performance optimization
- **Soft Launch:** [Dates and regions]
  - UK and Ireland initial release
  - Analytics implementation validation
  - Monetization performance assessment
- **Global Launch:** [Target date]
  - Full marketing push
  - All territories release

### 8.2 MVP Definition
- **Core Features for MVP:**
  - Basic wire connection mechanic
  - 25 playable levels
  - Simple progression system
  - Basic theme implementation
  - Ad integration (interstitial and rewarded)

### 8.3 Feature Prioritization
- **Must Have (MVP):**
  - Core wire connection gameplay
  - Level creation system
  - Basic monetization (ads)
  - Tutorial system
  - Analytics implementation

- **Should Have (Launch):**
  - 50+ levels
  - Multiple node types
  - Visual themes system
  - IAP implementation
  - Achievement system

- **Could Have (Post-launch):**
  - Daily challenges
  - Social features
  - Level editor
  - Cloud saves
  - Limited-time events

- **Won't Have (Out of scope):**
  - Multiplayer functionality
  - User-generated content sharing
  - Subscription model
  - Licensed IP themes

### 8.4 Post-Launch Support
- **Update Cadence:** Bi-weekly content updates
- **Content Roadmap:** Add 10-15 new levels per update
- **Live Ops Events:** Monthly themed events with special puzzles

---

## 9. Testing Strategy

### 9.1 QA Methodology
- **Testing Phases:**
  - Unit testing for core mechanics
  - Playtesting for level design
  - Device compatibility testing
  - Performance testing

- **Device Coverage:**
  - Primary test devices: iPhone 11, Samsung Galaxy S10
  - Minimum device coverage: 5 iOS and 8 Android devices
  - Cloud testing services: Firebase Test Lab

### 9.2 Monetization Testing
- Ad integration testing across networks
- IAP flow testing on both platforms
- Currency balance testing
- Ad frequency and placement optimization

### 9.3 Soft Launch
- **Target Regions:** UK, Ireland, New Zealand
- **Duration:** 4-6 weeks
- **Success Criteria:**
  - D1 Retention: >40%
  - D7 Retention: >20%
  - ARPDAU: >$0.03
  - Crash-free users: >99%

### 9.4 User Testing
- **Playtest Strategy:**
  - Internal playtesting throughout development
  - Closed beta with 100-200 users
  - Open beta in limited regions

---

## 10. Legal and Compliance

### 10.1 Privacy Policy
- Data collection practices for analytics
- Ad network data sharing policies
- User rights and opt-out procedures
- Children's privacy protection measures

### 10.2 Terms of Service
- User restrictions
- Content ownership
- Account termination conditions

### 10.3 Platform Compliance
- **App Store Guidelines:**
  - Age rating: 4+
  - Required privacy disclosures
  - IAP compliance

- **Google Play Guidelines:**
  - Target audience and content
  - Ad policy compliance
  - Permission justifications

### 10.4 Ad Network Compliance
- Ad content restrictions (family-friendly only)
- Ad frequency limitations
- Ad placement guidelines

### 10.5 GDPR/CCPA Compliance
- User consent implementation
- Data processing records
- Data retention policies

---

## 11. Risk Assessment

### 11.1 Technical Risks
- Performance issues on lower-end devices: Test early on minimum spec devices
- Unity version compatibility: Lock version early, cautious with updates
- File size management: Implement asset compression and optimization

### 11.2 Market Risks
- Saturated puzzle market: Focus on unique connection mechanics and visual satisfaction
- Ad revenue fluctuations: Diversify ad networks and implement mediation
- Low organic visibility: Invest in ASO and targeted UA campaigns

### 11.3 Resource Risks
- Art asset production delays: Establish modular art system with reusable elements
- Level design bottlenecks: Create robust level editor for rapid iteration
- Testing coverage limitations: Leverage community beta testing

---

## 12. Appendices

### 12.1 Glossary of Terms
- **Pulses:** In-game soft currency
- **Node:** Connection point in the game's circuit puzzles
- **Wire:** Line drawn between nodes to create connections
- **ARPDAU:** Average Revenue Per Daily Active User
- **Fill Rate:** Percentage of ad requests that are fulfilled with ads

### 12.2 Reference Materials
- Competitive analysis spreadsheet
- Art style mood board
- Puzzle game market research summary

### 12.3 Contact Information
- **Project Lead:** [Name, contact info]
- **Technical Lead:** [Name, contact info]
- **Art Director:** [Name, contact info]
- **Business Development:** [Name, contact info]

---

*Document Version:* 1.0
*Last Updated:* 13/05/2025
*Document Owner:* [NameCompany] 